using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccLib;
using TccLib.Extensions;
using TccLib.Drawing.Extensions;
using IssueTracker.Data;

namespace IssueTracker.App
{
    internal partial class NewIssueControlHost : UserControl, INavigableControlHost
    {
        private readonly HashSet<Data.Label> mSelectedLabels = new HashSet<Data.Label>();
        private readonly StringFormat mMiddleLeftFormat = 
            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };

        public NewIssueControlHost(Project project)
        {
            if (project == null) throw new ArgumentNullException("project");

            InitializeComponent();
            this.Project = project;
        }

        public Control Control{ get { return this; } }
        public Project Project { get; private set; }

        public event EventHandler<ReadOnlyValueEventArgs<Issue>> IssueCreated;

        public INavigationController NavigationController
        {
            get;
            set;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (var lDataContext = new IssueTrackerDataContext())
            {
                this.mListBoxLabels.Items.AddRange(lDataContext.Labels.OrderBy(x => x.Name).ToArray());
            }
        }

        private void ListBoxLabels_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Diagnostics.Debug.Assert(e.Index >= 0);

            var lLabel = (IssueTracker.Data.Label)this.mListBoxLabels.Items[e.Index];
            var lIsSelected = this.mSelectedLabels.Contains(lLabel);

            using (var lLabelColorBrush = new SolidBrush(Color.FromArgb(lLabel.ColorValue)))
            {
                if (lIsSelected)
                {
                    var lBoldFont = new Font(e.Font, FontStyle.Bold);

                    e.Graphics.FillRoundedRectangle(lLabelColorBrush, e.Bounds, 5);
                    e.Graphics.DrawString(lLabel.Name, lBoldFont, Brushes.Black, e.Bounds, mMiddleLeftFormat);
                }
                else
                {
                    if ((e.State & DrawItemState.HotLight) == DrawItemState.HotLight)
                    {
                        e.Graphics.FillRectangle(Brushes.AliceBlue, e.Bounds);
                    }

                    const int lcPadding = 5;
                    const int lcMargin = 10;
                    const int lcColorMarkerWidth = 5;

                    var lLabelColorMarkerBounds = new Rectangle(
                        e.Bounds.Left, e.Bounds.Top + lcPadding,
                        lcColorMarkerWidth, e.Bounds.Height - lcPadding - lcPadding);

                    var lTextBounds = new Rectangle(
                        lLabelColorMarkerBounds.Right + lcMargin, e.Bounds.Top,
                        e.Bounds.Width - lLabelColorMarkerBounds.Right - lcMargin, e.Bounds.Height);

                    e.Graphics.FillRoundedRectangle(lLabelColorBrush, lLabelColorMarkerBounds, lcColorMarkerWidth / 2);
                    e.Graphics.DrawString(lLabel.Name, e.Font, Brushes.Black, lTextBounds, mMiddleLeftFormat);
                }
            }
        }

        private void ListBoxLabels_MouseClick(object sender, MouseEventArgs e)
        {
            var lIndex = this.mListBoxLabels.IndexFromPoint(e.Location);
            if (lIndex < 0) return;

            var lLabel = (Data.Label)this.mListBoxLabels.Items[lIndex];
            if (this.mSelectedLabels.Contains(lLabel))
            {
                this.mSelectedLabels.Remove(lLabel);
            }
            else
            {
                this.mSelectedLabels.Add(lLabel);
            }

            this.mListBoxLabels.Invalidate();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            using (var lDataContext = new IssueTrackerDataContext())
            {
                var lIssue = new Issue();
                lIssue.ProjectId = this.Project.Id;
                lIssue.Title = this.mTextBoxTitle.Text;
                lIssue.Body = this.mTextPreviewViewBody.Text;
                lIssue.CreationDateTime = DateTime.UtcNow;
                lIssue.LastUpdatedDateTime = DateTime.UtcNow;
                lIssue.OpenedByUser = lDataContext.CurrentUser;
                lIssue.IsOpen = true;
                lDataContext.Issues.InsertOnSubmit(lIssue);

                foreach (var lLabel in this.mSelectedLabels)
                {
                    var lIssueLabel = new IssueLabel();
                    lIssueLabel.Issue = lIssue;
                    lIssueLabel.LabelId = lLabel.Id;

                    lDataContext.IssueLabels.InsertOnSubmit(lIssueLabel);
                }

                lDataContext.SubmitChanges();

                this.IssueCreated.Fire(this, ReadOnlyValueEventArgs.Create(lIssue));
            }
        }
    }
}
