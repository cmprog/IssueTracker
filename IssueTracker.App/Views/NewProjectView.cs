using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccLib.Extensions;

namespace IssueTracker.App.Views
{
    /// <summary>
    /// Displays a form allowing the user to create a new project.
    /// </summary>
    internal partial class NewProjectView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the NewProjectView.
        /// </summary>
        public NewProjectView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fired when the text entered by the user needs to be processed
        /// for display in the preview browser.
        /// </summary>
        public event EventHandler<TextPreviewProcessTextEventArgs> ProcessText;

        /// <summary>
        /// Fired when the user is done creating the new project.
        /// </summary>
        public event EventHandler Commit;

        /// <summary>
        /// Gets or sets the title text.
        /// </summary>
        public string Title
        {
            get { return this.mTextBoxTitle.Text; }
            set { this.mTextBoxTitle.Text = value; }
        }

        /// <summary>
        /// Gets or sets the body text.
        /// </summary>
        public string Body
        {
            get { return this.mTextPreviewViewBody.Text; }
            set { this.mTextPreviewViewBody.Text = value; }
        }

        /// <summary>
        /// We will simply forward the event from the preview view to our own callers
        /// handlers.
        /// </summary>
        private void TextPreviewViewBody_ProcessText(object sender, TextPreviewProcessTextEventArgs e)
        {
            this.ProcessText.Fire(this, e);
        }

        /// <summary>
        /// When the create button is clicked, we inform the world to commit changes.
        /// </summary>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            this.Commit.Fire(this);
        }
    }
}
