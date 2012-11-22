using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TccLib.Cocoa
{
    /// <summary>
    /// A stack-based view controller which displays other view controllers by placing them
    /// inside a panel one by one and coordinating the transitions between them.
    /// </summary>
    public sealed class NavigationViewController : ViewController
    {
        /// <summary>
        /// Initializes a new instance of the NavigationViewController class.
        /// </summary>
        /// <param name="rootViewController"></param>
        public NavigationViewController(IViewController rootViewController)
        {
            if (rootViewController == null) throw new ArgumentNullException("rootViewController");

            this.ViewControllers = new Stack<IViewController>();
            this.ViewControllers.Push(rootViewController);

            this.ContainerControl = new ContainerControl();
            this.View = this.ContainerControl;

            this.ShowViewController(this.TopViewController);
        }

        private ContainerControl ContainerControl { get; set; }

        /// <summary>
        /// Gets or sets the stack of view controllers.
        /// </summary>
        private Stack<IViewController> ViewControllers { get; set; }

        /// <summary>
        /// Gets or sets the top-most view controller.
        /// </summary>
        public IViewController TopViewController
        {
            get { return this.ViewControllers.Peek(); }
        }

        /// <summary>
        /// Pushes the given view controller onto the stack.
        /// </summary>
        /// <param name="viewController">The ViewController to push.</param>
        public void PushViewController(IViewController viewController)
        {
            if (viewController == null) throw new ArgumentNullException("viewController");
            
            this.HideViewController(this.TopViewController);
            this.ViewControllers.Push(viewController);
            this.ShowViewController(this.TopViewController);
        }

        /// <summary>
        /// Pops the top-most ViewController from the stack.
        /// </summary>
        public void PopViewController()
        {
            if (this.ViewControllers.Count == 1)
            {
                throw new InvalidOperationException(
                    "Cannot remove the root ViewController from the navigation stack.");
            }

            this.HideViewController(this.TopViewController);
            this.ViewControllers.Pop();
            this.ShowViewController(this.TopViewController);
        }

        /// <summary>
        /// Pops all the ViewControllers off the stack except for the root view controller.
        /// </summary>
        public void PopToRootViewController()
        {
            if (this.ViewControllers.Count == 1) return;

            this.HideViewController(this.TopViewController);

            while (this.ViewControllers.Count > 1)
            {
                this.ViewControllers.Pop();
            }

            this.ShowViewController(this.TopViewController);
        }

        /// <summary>
        /// Pops all the ViewControllers off the stack until the view ViewController if displayed.
        /// </summary>
        /// <param name="viewController">The view controller to display.</param>
        public void PopToViewController(IViewController viewController)
        {
            if (viewController == null) throw new ArgumentNullException("viewController");

            if (this.TopViewController == viewController) return;

            this.HideViewController(this.TopViewController);

            while ((this.ViewControllers.Count > 1) && (this.TopViewController != viewController))
            {
                this.ViewControllers.Pop();
            }

            if (this.TopViewController != viewController)
            {
                throw new ArgumentException(
                    "The given ViewController was not found in the navigation stack.",
                    "viewController");
            }

            this.ShowViewController(viewController);
        }

        /// <summary>
        /// Shows the given ViewController.
        /// </summary>
        /// <param name="viewController">The ViewController to show.</param>
        private void ShowViewController(IViewController viewController)
        {
            System.Diagnostics.Debug.Assert(viewController != null);

            viewController.ViewWillAppear();
            viewController.View.Dock = DockStyle.Fill;
            this.ContainerControl.Controls.Add(viewController.View);
            viewController.ViewDidAppear();
        }

        /// <summary>
        /// Hides the given view controller from view.
        /// </summary>
        /// <param name="viewController">The ViewController to hide.</param>
        private void HideViewController(IViewController viewController)
        {
            System.Diagnostics.Debug.Assert(viewController != null);

            viewController.ViewWillDisappear();
            this.ContainerControl.Controls.Remove(viewController.View);
            viewController.ViewDidDisappear();
        }
    }
}
