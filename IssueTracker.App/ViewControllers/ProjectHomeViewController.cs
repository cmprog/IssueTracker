//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using IssueTracker.Data;
//using IssueTracker.App.Views;
//using TccLib.Cocoa;
//using IssueTracker.App.Models;

//namespace IssueTracker.App.ViewControllers
//{
//    internal sealed class ProjectHomeViewController : ViewController
//    {
//        /// <summary>
//        /// Initializes a new instance of the ProjectHomeViewController class.
//        /// </summary>
//        /// <param name="project">The Project which is loaded.</param>
//        public ProjectHomeViewController(Project project)
//        {
//            if (project == null) throw new ArgumentNullException("project");

//            this.Project = project;

//            this.View = new ProjectHomeView();
//            base.View = this.View;
//            this.View.FetchIssues += this.View_FetchIssues;
//        }

//        /// <summary>
//        /// Gets the ProjectHomeView managed by this ViewController.
//        /// </summary>
//        public new ProjectHomeView View { get; private set; }

//        /// <summary>
//        /// Gets or sets the Project which is loaded.
//        /// </summary>
//        private Project Project { get; set; }

//        /// <summary>
//        /// Fetches issues for the view.
//        /// </summary>
//        private void View_FetchIssues(object sender, FetchIssuesEventArgs e)
//        {
//            using (var lDataContext = new IssueTrackerDataContext())
//            {
//                IQueryable<Issue> lIssues = lDataContext.Issues;

//                switch (e.Status)
//                {
//                    case FetchIssueStatus.Open:
//                        lIssues = lIssues.Where(x => x.IsOpen);
//                        break;

//                    case FetchIssueStatus.Closed:
//                        lIssues = lIssues.Where(x => !x.IsOpen);
//                        break;
//                }

//                switch (e.Filter)
//                {
//                    case FetchIssueFilter.CreatedByUser:
//                        lIssues = lIssues.Where(x => x.OpenedByUser == lDataContext.CurrentUser);
//                        break;

//                    case FetchIssueFilter.AssignedToUser:
//                        lIssues = lIssues.Where(x => x.AssignedUser == lDataContext.CurrentUser);
//                        break;
//                }

//                if (!string.IsNullOrWhiteSpace(e.SearchText))
//                {
//                    lIssues = lIssues.Where(x => x.Title.Contains(e.SearchText) || x.Body.Contains(e.SearchText));
//                }

//                e.Results = lIssues
//                    .AsEnumerable()
//                    .Select(x => new IssueModel(x))
//                    .ToArray();
//            }
//        }
//    }
//}
