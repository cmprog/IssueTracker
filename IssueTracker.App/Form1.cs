using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IssueTracker.App.ViewControllers;
using TccLib.Cocoa;

namespace IssueTracker.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            this.splitContainer1.Panel2.Controls.Add(this.NavigationViewController.View);
        }
    }
}
