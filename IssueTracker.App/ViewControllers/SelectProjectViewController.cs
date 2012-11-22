using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IssueTracker.App.Views;
using TccLib.Cocoa;

namespace IssueTracker.App.ViewControllers
{
    internal sealed class SelectProjectViewController : ViewController
    {
        public SelectProjectViewController()
        {
            this.View = new SelectProjectView();
        }
    }
}
