using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IssueTracker.Data;
using IssueTracker.App.Views;
using TccLib.Cocoa;

namespace IssueTracker.App.ViewControllers
{
    internal sealed class ProjectHomeViewController : ViewController
    {
        public ProjectHomeViewController(Project project)
        {
            this.View = new ProjectHomeView();
        }
    }
}
