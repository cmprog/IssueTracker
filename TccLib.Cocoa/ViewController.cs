using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TccLib.Cocoa
{
    /// <summary>
    /// Defines a simply view controller which may serve as a base class for all objects
    /// wishing to implement the IViewController interface.
    /// </summary>
    public abstract class ViewController : IViewController
    {
        /// <summary>
        /// Initializes a new instance of the BaseViewController class.
        /// </summary>
        public ViewController()
        {
            this.Title = string.Empty;
        }

        /// <summary>
        /// Gets the title of the view controller.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Gets the View associated with the view controler.
        /// </summary>
        public Control View { get; protected set; }

        /// <summary>
        /// Notified the view controller the view is about to appear.
        /// </summary>
        public virtual void ViewWillAppear()
        {
        }

        /// <summary>
        /// Gets or sets the navigation view controller
        /// associated with this view controller.
        /// </summary>
        public virtual NavigationViewController NavigationViewController { get; set; }

        /// <summary>
        /// Notifies the view controller the view has appeared.
        /// </summary>
        public virtual void ViewDidAppear()
        {
        }

        /// <summary>
        /// Notifies the view controller the view is about to disappear.
        /// </summary>
        public virtual void ViewWillDisappear()
        {
        }
        
        /// <summary>
        /// Notifies the view controller the view has disappeared.
        /// </summary>
        public virtual void ViewDidDisappear()
        {
        }
    }
}
