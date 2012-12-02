using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IssueTracker.App.Models;
using TccLib;
using TccLib.Extensions;
using TccLib.WinForms.Extensions;

namespace IssueTracker.App.Views
{
    internal partial class ProjectHomeView : UserControl
    {
        public ProjectHomeView()
        {
            InitializeComponent();

            this.mListBoxOpenIssues.ToggleDoubleBuffering(true);
        }

        /// <summary>
        /// Fired when the view needs an enumerable collection of open issues to display.
        /// </summary>
        public event EventHandler<FetchIssuesEventArgs> FetchIssues;

        /// <summary>
        /// Loads the initial state of the view.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            var lFetchOpenIssuesEventArgs = new FetchIssuesEventArgs(FetchIssueFilter.All, FetchIssueStatus.Open, this.mTextBoxSearch.Text);
            this.FetchIssues.Fire(this, lFetchOpenIssuesEventArgs);

            var lOpenIssues = lFetchOpenIssuesEventArgs.Results.ToArray();
            this.mTabPageOpenIssues.Text = string.Format("{0} open issue{1}", lOpenIssues.Length, (lOpenIssues.Length == 1) ? string.Empty : "s");
            this.mListBoxOpenIssues.Items.AddRange(lOpenIssues);

            var lFetchClosedIssuesEventArgs = new FetchIssuesEventArgs(FetchIssueFilter.All, FetchIssueStatus.Closed, this.mTextBoxSearch.Text);
            this.FetchIssues.Fire(this, lFetchClosedIssuesEventArgs);

            var lClosedIssues = lFetchClosedIssuesEventArgs.Results.ToArray();
            this.mTabPageClosedIssues.Text = string.Format("{0} closed issue{1}", lClosedIssues.Length, (lClosedIssues.Length == 1) ? string.Empty : "s");
        }

        /// <summary>
        /// Draws the given issue to the list box with the given draw event arguments.
        /// </summary>
        private void ListBoxIssues_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var lSenderListBox = (ListBox)sender;
            var lIssueModel = (IssueModel)lSenderListBox.Items[e.Index];

            e.Graphics.DrawString(lIssueModel.Title, e.Font, SystemBrushes.ControlText, e.Bounds.X, e.Bounds.Y);
        }
    }
}
