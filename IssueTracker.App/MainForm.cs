using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IssueTracker.App.ViewControllers;
using TccLib.WinForms;
using TccLib.WinForms.Extensions;
using TccLib.Cocoa;
using IssueTracker.Data;

namespace IssueTracker.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.mListBoxProjects.ToggleDoubleBuffering(true);
        }

        /// <summary>
        /// Gets the main NavigationViewController which will manage the body
        /// of the form.
        /// </summary>
        private NavigationViewController NavigationViewController { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var lRootViewController = new SelectProjectViewController();
            this.NavigationViewController = new NavigationViewController(lRootViewController);
            this.NavigationViewController.View.Dock = DockStyle.Fill;
            this.mSplitContainer.Panel2.Controls.Add(this.NavigationViewController.View);

            using (var lDataContext = new IssueTrackerDataContext())
            {
                var lProjects = lDataContext.Projects.ToArray();
                var lWrappers = lProjects.Select(x => GenericWrapper.Create(x, proj => proj.Name)).ToArray();

                this.mListBoxProjects.Items.AddRange(lWrappers);
                this.mListBoxProjects.Items.Add(GenericWrapper.Create<Project>(null, x => "Create New Project"));
            }
        }

        private void ListBoxProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lIndex = this.mListBoxProjects.IndexFromPoint(e.Location);
            if (lIndex < 0) return;

            var lRawProject = this.mListBoxProjects.Items[lIndex];
            var lProject = GenericWrapper<Project>.UnWrap(lRawProject);

            if (lProject == null)
            {
                var lNewProjectViewController = new NewProjectViewController();
                lNewProjectViewController.ProjectCreated += (s, args) => this.OnProjectCreated(args.Value);
                this.NavigationViewController.PushViewController(lNewProjectViewController);
            }
            else
            {
                this.OpenProject(lProject);
            }
        }

        /// <summary>
        /// Opens the given project.
        /// </summary>
        /// <param name="project">The project to open.</param>
        private void OpenProject(Project project)
        {
            var lProjectHomeViewController = new ProjectHomeViewController(project);

            this.NavigationViewController.PopToRootViewController();
            this.NavigationViewController.PushViewController(lProjectHomeViewController);
        }

        /// <summary>
        /// Performs all actions for when a project is created.
        /// </summary>
        /// <param name="project">The project which was created.</param>
        private void OnProjectCreated(Project project)
        {
            this.mListBoxProjects.Items.Insert(0, WrapProject(project));
            this.mListBoxProjects.SelectedIndex = 0;
            this.OpenProject(project);
        }

        /// <summary>
        /// Wraps the given valid project object.
        /// </summary>
        /// <param name="project">The project to wrap.</param>
        /// <returns>The wrapped project.</returns>
        private static GenericWrapper<Project> WrapProject(Project project)
        {
            System.Diagnostics.Debug.Assert(project != null, "This function only wraps valid project objects.");
            return new GenericWrapper<Project>(project, x => x.Name);
        }
    }
}
