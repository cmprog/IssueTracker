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
using IssueTracker.Data;

namespace IssueTracker.App
{
    /// <summary>
    /// Displays a form allowing the user to create a new project.
    /// </summary>
    internal partial class NewProjectView : UserControl, INavigableControlHost
    {
        /// <summary>
        /// Initializes a new instance of the NewProjectView.
        /// </summary>
        public NewProjectView()
        {
            InitializeComponent();
        }

        public event EventHandler<ReadOnlyValueEventArgs<Project>> ProjectCreated;

        /// <summary>
        /// When the create button is clicked, we inform the world to commit changes.
        /// </summary>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var lProject = new Project();
            lProject.Name = this.mTextBoxTitle.Name;
            lProject.Description = this.mTextPreviewViewBody.Text;
            lProject.CreationDateTIme = DateTime.UtcNow;

            using (var lDataContext = new IssueTrackerDataContext())
            {
                var lProjectUser = new ProjectUser();
                lProjectUser.Project = lProject;
                lProjectUser.User = lDataContext.CurrentUser;

                lDataContext.Projects.InsertOnSubmit(lProject);
                lDataContext.ProjectUsers.InsertOnSubmit(lProjectUser);

                lDataContext.SubmitChanges();
            }

            this.ProjectCreated.Fire(this, ReadOnlyValueEventArgs.Create(lProject));
        }

        public Control Control
        {
            get { return this; }
        }

        public INavigationController NavigationController
        {
            get;
            set;
        }
    }
}
