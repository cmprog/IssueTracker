using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TccLib;
using TccLib.Extensions;
using TccLib.Cocoa;
using IssueTracker.Data;
using IssueTracker.App.Views;

namespace IssueTracker.App.ViewControllers
{
    /// <summary>
    /// ViewController for the NewProjectView.
    /// </summary>
    internal sealed class NewProjectViewController : ViewController
    {
        /// <summary>
        /// Initializes a new instance of the NewProjectViewController class.
        /// </summary>
        public NewProjectViewController()
        {
            this.View = new NewProjectView();
            base.View = this.View;
            this.View.ProcessText += this.View_ProcessText;
            this.View.Commit += this.View_Commit;
        }

        /// <summary>
        /// Gets the NewProjectView managed by this ViewController.
        /// </summary>
        public new NewProjectView View { get; private set; }

        /// <summary>
        /// Fired when the project is created.
        /// </summary>
        public event EventHandler<ReadOnlyValueEventArgs<Project>> ProjectCreated;

        /// <summary>
        /// Processes the text converting it to HTML.
        /// </summary>
        private void View_ProcessText(object sender, TextPreviewProcessTextEventArgs e)
        {
            var lMarkdown = new MarkdownSharp.Markdown();
            e.ProcessedText = lMarkdown.Transform(e.Text);
        }

        /// <summary>
        /// Creates the project and transitions to the new project's home view.
        /// </summary>
        private void View_Commit(object sender, EventArgs e)
        {
            var lProject = new Project();
            lProject.Name = this.View.Title;
            lProject.Description = this.View.Body;

            using (var lDataContext = new IssueTrackerDataContext())
            {
                lDataContext.Projects.InsertOnSubmit(lProject);
                lDataContext.SubmitChanges();
            }

            this.ProjectCreated.Fire(this, ReadOnlyValueEventArgs.Create(lProject));
        }
    }
}
