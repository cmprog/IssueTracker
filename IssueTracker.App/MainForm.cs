using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccLib.Drawing.Extensions;
using TccLib.WinForms;
using TccLib.WinForms.Extensions;
using IssueTracker.Data;

namespace IssueTracker.App
{
    internal partial class MainForm : Form, INavigationController
    {
        public MainForm()
        {
            InitializeComponent();
            this.mListBoxProjects.ToggleDoubleBuffering(true);
            this.ControlHosts = new Stack<INavigableControlHost>();
        }

        private Stack<INavigableControlHost> ControlHosts { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.RootControlHost = new SelectProjectView();
            this.ControlHosts.Push(this.RootControlHost);
            this.ShowControlHost(this.RootControlHost);

            using (var lDataContext = new IssueTrackerDataContext())
            {
                var lProjects = lDataContext.Projects.ToArray();

                this.mListBoxProjects.Items.AddRange(lProjects);
                this.mListBoxProjects.Items.Add("Create New Project...");
            }
        }

        private void ListBoxProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lIndex = this.mListBoxProjects.IndexFromPoint(e.Location);
            if (lIndex < 0) return;

            var lRawProject = this.mListBoxProjects.Items[lIndex];
            var lProject = lRawProject as Project;

            if (lProject == null)
            {
                var lNewProjectView = new NewProjectView();
                lNewProjectView.ProjectCreated += (s, args) => this.OnProjectCreated(args.Value);
                this.PushControlHost(lNewProjectView);
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
            var lProjectHomeView = new ProjectHomeView(project);
            this.PopToRootControlHost();
            this.PushControlHost(lProjectHomeView);
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

        public INavigableControlHost RootControlHost
        {
            get; 
            private set;
        }

        private INavigableControlHost TopControlHost
        {
            get { return this.ControlHosts.Peek(); }
        }

        public void PushControlHost(INavigableControlHost controlHost)
        {
            if (controlHost == null) throw new ArgumentNullException("controlHost");

            controlHost.NavigationController = this;

            this.HideControlHost(this.TopControlHost);
            this.ControlHosts.Push(controlHost);
            this.ShowControlHost(this.TopControlHost);
        }

        public void PopControlHost()
        {
            if (this.ControlHosts.Count == 1)
            {
                throw new InvalidOperationException(
                    "Cannot remove the RootControlHost.");
            }

            this.HideControlHost(this.TopControlHost);
            this.ControlHosts.Pop();
            this.ShowControlHost(this.TopControlHost);
        }

        public void PopToRootControlHost()
        {
            if (this.ControlHosts.Count == 1) return;

            this.HideControlHost(this.TopControlHost);
            while (this.ControlHosts.Count > 1) this.ControlHosts.Pop();
            this.ShowControlHost(this.TopControlHost);
        }

        public void PopToControlHost(INavigableControlHost controlHost)
        {
            if (controlHost == null) throw new ArgumentNullException("controlHost");
            if (this.TopControlHost == controlHost) return;

            this.HideControlHost(this.TopControlHost);

            while ((this.ControlHosts.Count > 1) && (this.TopControlHost != controlHost))
            {
                this.ControlHosts.Pop();
            }

            if (this.TopControlHost != controlHost)
            {
                throw new ArgumentException(
                    "The given control host was not found in the navigation stack.");
            }

            this.ShowControlHost(this.TopControlHost);
        }

        private void HideControlHost(INavigableControlHost controlHost)
        {
            System.Diagnostics.Debug.Assert(controlHost != null);
            System.Diagnostics.Debug.Assert(controlHost.Control.Parent == this);

            controlHost.Control.Parent = null;
        }

        private void ShowControlHost(INavigableControlHost controlHost)
        {
            System.Diagnostics.Debug.Assert(controlHost != null);

            var lRight = this.mListBoxProjects.Right;
            var lWidth = this.mListBoxProjects.Width;

            var lTopOffset = (controlHost == this.RootControlHost)
                ? 0 : this.mLinkLabelBack.Height + this.mLinkLabelBack.Margin.Bottom;

            var lControl = controlHost.Control;
            lControl.SuspendLayout();
            lControl.Parent = this;
            lControl.Dock = DockStyle.None;
            lControl.Top = this.mLinkLabelBack.Top + lTopOffset;
            lControl.Left = this.mLinkLabelBack.Left;
            lControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lControl.Width = this.ClientSize.Width - this.mListBoxProjects.Right - this.Padding.Right - this.mListBoxProjects.Margin.Right;
            lControl.Height = this.mListBoxProjects.Height - lTopOffset;
            lControl.BringToFront();
            lControl.ResumeLayout();
        }

        private void LinkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PopControlHost();
        }

        private void ListBoxProjects_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Diagnostics.Debug.Assert(e.Index >= 0);

            var lIsSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            var lBackBrush = lIsSelected ? SystemBrushes.Highlight : SystemBrushes.Window;

            e.Graphics.FillRoundedRectangle(lBackBrush, e.Bounds, 10);

            var lTextBrush = lIsSelected ? SystemBrushes.HighlightText : SystemBrushes.ControlText;

            if (e.Index == this.mListBoxProjects.Items.Count - 1)
            {
                var lText = (string)this.mListBoxProjects.Items[e.Index];
                e.Graphics.DrawString(lText, e.Font, lTextBrush, e.Bounds);
            }
            else
            {
                var lProject = (Project)this.mListBoxProjects.Items[e.Index];
                e.Graphics.DrawString(lProject.Name, e.Font, lTextBrush, e.Bounds);
            }
        }
    }
}
