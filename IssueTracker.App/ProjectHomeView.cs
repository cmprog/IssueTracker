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
using TccLib.WinForms.Extensions;
using IssueTracker.Data;

namespace IssueTracker.App
{
    internal sealed partial class ProjectHomeView : UserControl, INavigableControlHost
    {
        private enum IssueFilter
        {
            All,
            AssignedToCurrentUser,
            CreatedByCurrentUser
        }

        public ProjectHomeView(Project project)
        {
            if (project == null) throw new ArgumentNullException("project");

            InitializeComponent();

            this.Project = project;
            this.mListBoxOpenIssues.ToggleDoubleBuffering(true);
            this.SelectedFilter = IssueFilter.All;
        }

        public Control Control { get { return this; } }
        public Project Project { get; private set; }
        private IssueFilter SelectedFilter { get; set; }
        public INavigationController NavigationController { get; set; }

        /// <summary>
        /// Loads the initial state of the view.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            this.RefreshIssues();
        }

        private void RefreshIssues()
        {
            using (var lDataContext = new IssueTrackerDataContext())
            {
                var lProjectIssues = lDataContext.Issues
                    .Where(x => x.ProjectId == this.Project.Id);

                if (!string.IsNullOrWhiteSpace(this.mTextBoxSearch.Text))
                {
                    lProjectIssues = lProjectIssues
                        .Where(x => x.Title.Contains(this.mTextBoxSearch.Text));
                }

                switch (this.SelectedFilter)
                {
                    case IssueFilter.AssignedToCurrentUser:
                        lProjectIssues = lProjectIssues
                            .Where(x => x.AssignedUser == lDataContext.CurrentUser);
                        break;

                    case IssueFilter.CreatedByCurrentUser:
                        lProjectIssues = lProjectIssues
                            .Where(x => x.OpenedByUser == lDataContext.CurrentUser);
                        break;
                }

                var lOpenIssues = lProjectIssues.Where(x => x.IsOpen).ToArray();
                this.mTabPageOpenIssues.Text = string.Format("{0} open issue{1}", lOpenIssues.Length, (lOpenIssues.Length == 1) ? string.Empty : "s");
                this.mListBoxOpenIssues.Items.Clear();
                this.mListBoxOpenIssues.Items.AddRange(lOpenIssues);

                var lClosedIssues = lProjectIssues.Where(x => !x.IsOpen).ToArray();
                this.mTabPageClosedIssues.Text = string.Format("{0} closed issue{1}", lClosedIssues.Length, (lClosedIssues.Length == 1) ? string.Empty : "s");
                this.mListBoxClosedIssues.Items.Clear();
                this.mListBoxClosedIssues.Items.AddRange(lClosedIssues);
            }
        }

        private void RefreshMilestones()
        {
        }

        /// <summary>
        /// Draws the given issue to the list box with the given draw event arguments.
        /// </summary>
        private void ListBoxIssues_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var lSenderListBox = (ListBox)sender;
            var lIssueModel = (Issue)lSenderListBox.Items[e.Index];

            e.Graphics.DrawString(lIssueModel.Title, e.Font, SystemBrushes.ControlText, e.Bounds.X, e.Bounds.Y);
        }

        private void TabControlIssues_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == this.mTabPageOpenIssues)
            {
                this.mButtonAdd.Text = "New Issue";
            }
            else if (e.TabPage == this.mTabPageClosedIssues)
            {
                this.mButtonAdd.Text = "New Milestone";
            }
            else
            {
                System.Diagnostics.Debug.Assert(
                    false, "Surely, we're selecting one of the tab pages...");
            }
        }

        private void ButtonIssuesEventone_Click(object sender, EventArgs e)
        {
            if (this.SelectedFilter == IssueFilter.All) return;
            this.SelectedFilter = IssueFilter.All;
            this.RefreshIssues();
        }

        private void ButtonIssuesAssigned_Click(object sender, EventArgs e)
        {
            if (this.SelectedFilter == IssueFilter.AssignedToCurrentUser) return;
            this.SelectedFilter = IssueFilter.AssignedToCurrentUser;
            this.RefreshIssues();
        }

        private void ButtonIssuesCreated_Click(object sender, EventArgs e)
        {
            if (this.SelectedFilter == IssueFilter.CreatedByCurrentUser) return;
            this.SelectedFilter = IssueFilter.CreatedByCurrentUser;
            this.RefreshIssues();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.mTimerSearch.Start();
        }

        private void TimerSearch_Tick(object sender, EventArgs e)
        {
            this.mTimerSearch.Stop();

            if (this.mTabControlMain.SelectedTab == this.mTabPageIssues)
            {
                this.RefreshIssues();
            }
            else
            {
                this.RefreshMilestones();
            }
        }
    }
}
