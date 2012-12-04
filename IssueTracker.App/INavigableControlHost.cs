using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IssueTracker.App
{
    interface INavigableControlHost
    {
        Control Control { get; }

        INavigationController NavigationController { get; set; }
    }
}
