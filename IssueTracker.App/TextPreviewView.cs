using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccLib.Extensions;

namespace IssueTracker.App
{
    /// <summary>
    /// Allows the user to enter in text while also showing a post-procsesed
    /// preview of the text.
    /// </summary>
    internal partial class TextPreviewView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the TextPreviewView class.
        /// </summary>
        public TextPreviewView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the user-input text.
        /// </summary>
        public override string Text
        {
            get { return this.mTextBoxUserInput.Text; }
            set { this.mTextBoxUserInput.Text = value; }
        }

        /// <summary>
        /// When the tab control is selecting the preview tab page, we must process
        /// the user input and display the processed text to the browser.
        /// </summary>
        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == this.mTabPagePreview)
            {
                this.mHtmlPanel.Text = MarkdownHelper.TranslateWithStyle(this.mTextBoxUserInput.Text);
            }
        }
    }
}
