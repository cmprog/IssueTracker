using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IssueTracker.App
{
    interface INavigationController
    {
        INavigableControlHost RootControlHost { get; }

        void PushControlHost(INavigableControlHost controlHost);
        void PopControlHost();
        void PopToRootControlHost();
        void PopToControlHost(INavigableControlHost controlHost);
    }
}
