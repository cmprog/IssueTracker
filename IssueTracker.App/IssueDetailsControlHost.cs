using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccLib.Drawing.Extensions;
using TccLib.Extensions;
using IssueTracker.Data;

namespace IssueTracker.App
{
    internal sealed partial class IssueDetailsControlHost : UserControl, INavigableControlHost
    {
        private readonly StringFormat mMiddleCenterFormat =
            new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        private readonly StringFormat mMiddleLeftFormat =
            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };

        public IssueDetailsControlHost(Issue issue)
        {
            if (issue == null) throw new ArgumentNullException("issue");

            InitializeComponent();

            this.Issue = issue;
        }

        public Control Control { get { return this; } }
        public INavigationController NavigationController { get; set; }
        public Issue Issue { get; private set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (var lDataContext = new IssueTrackerDataContext())
            {
                this.Issue = lDataContext.Issues.Single(x => x.Id == this.Issue.Id);

                this.mLabelAuthor.Text = this.Issue.OpenedByUser.FullName;
                this.mLabelAuthorFooter.Text = "opened this issue " + (DateTime.UtcNow - this.Issue.CreationDateTime).ToRelativePastTimeString();
                this.mLabelTitle.Text = this.Issue.Title;
                this.mLabelAssignedUser.Text = this.Issue.AssignedUser.Get(x => x.FullName, string.Empty);
                this.mLabelMilestone.Text = this.Issue.Milestone.Get(x => x.Title, string.Empty);
                this.mHtmlPanel.Text = MarkdownHelper.TranslateWithStyle(this.Issue.Body);

                this.mListBoxLabels.Items.AddRange(
                    this.Issue.IssueLabels.Select(x => x.Label).OrderBy(x => x.Name).ToArray());
            }
        }

        private void LabelAuthor_SizeChanged(object sender, EventArgs e)
        {
            this.mLabelAuthorFooter.Left = 
                this.mLabelAuthor.Right + this.mLabelAuthor.Margin.Right;
        }

        private void LabelAssignedUser_SizeChanged(object sender, EventArgs e)
        {
            this.mLabelAssignedUserFooter.Left =
                this.mLabelAssignedUser.Right + this.mLabelAssignedUser.Margin.Right;
        }

        private void LabelMilestone_SizeChanged(object sender, EventArgs e)
        {
            this.mLabelMilestone.Left =
                this.mProgressBarMilestone.Left - this.mLabelMilestone.Width - this.mProgressBarMilestone.Margin.Left;
            this.mLabelMilestoneHeader.Left =
                this.mLabelMilestone.Left - this.mLabelMilestoneHeader.Width - this.mLabelMilestone.Margin.Left;
        }

        private void ListBoxLabels_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Diagnostics.Debug.Assert(e.Index >= 0);

            var lLabel = (Data.Label)this.mListBoxLabels.Items[e.Index];

            using (var lLabelColorBrush = new SolidBrush(Color.FromArgb(lLabel.ColorValue)))
            {
                e.Graphics.FillRoundedRectangle(lLabelColorBrush, e.Bounds, 5);
                e.Graphics.DrawString(lLabel.Name, this.mPanelOpenStatus.Font, Brushes.Black, e.Bounds, this.mMiddleLeftFormat);
            }
        }

        private void PanelOpenStatus_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black,
                0, this.mPanelOpenStatus.Height,
                this.mPanelOpenStatus.Width, this.mPanelOpenStatus.Height);

            var lStatusRectangle = new Rectangle(0, 0, this.mPanelOpenStatus.Width, this.mPanelOpenStatus.Height - 5);
            var lFillBrush = this.Issue.IsOpen ? Brushes.LimeGreen : Brushes.Red;
            var lStatusText = this.Issue.IsOpen ? "Open" : "Closed";

            e.Graphics.FillRoundedRectangle(lFillBrush, lStatusRectangle, 10);
            e.Graphics.DrawString(lStatusText, this.mPanelOpenStatus.Font, Brushes.White, lStatusRectangle, this.mMiddleCenterFormat);
        }

        private void mButtonEdit_Click(object sender, EventArgs e)
        {
            if (!this.mHtmlPanel.Visible) return;

            this.mTextBoxTitle.Text = this.Issue.Title;
            this.mTextPreviewViewBody.Text = this.Issue.Body;
            this.mHtmlPanel.Visible = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.mHtmlPanel.Visible = true;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            using (var lDataContext = new IssueTrackerDataContext())
            {
                this.Issue = lDataContext.Issues.Single(x => x.Id == this.Issue.Id);
                this.Issue.LastUpdatedDateTime = DateTime.UtcNow;
                this.Issue.Title = this.mTextBoxTitle.Text;
                this.Issue.Body = this.mTextPreviewViewBody.Text;
                lDataContext.SubmitChanges();
            }

            this.mLabelTitle.Text = this.Issue.Title;
            this.mHtmlPanel.Text = MarkdownHelper.TranslateWithStyle(this.Issue.Body);
            this.mHtmlPanel.Visible = true;
        }
    }
}
