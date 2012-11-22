using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TccLib.Cocoa
{
    /// <summary>
    /// Defines an interface for a ViewController. A view controller is responsible for a
    /// single View (i.e. a Control).
    /// </summary>
    public interface IViewController
    {
        /// <summary>
        /// Gets the title of the view.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Gets the view the view controller is responsible for.
        /// </summary>
        Control View { get; }

        /// <summary>
        /// Informs the controller the view is about to appear on the screen.
        /// </summary>
        void ViewWillAppear();

        /// <summary>
        /// Gets or sets the navigation view controller responsible for navigating
        /// from one view controller to another.
        /// </summary>
        NavigationViewController NavigationViewController { get; set; }

        /// <summary>
        /// Informs the controller the view appeared on the screen.
        /// </summary>
        void ViewDidAppear();

        /// <summary>
        /// Informs the controller the view is about to disappear from the screen.
        /// </summary>
        void ViewWillDisappear();

        /// <summary>
        /// Informs the controller the view has disappeared from the screen.
        /// </summary>
        void ViewDidDisappear();
    }
}
