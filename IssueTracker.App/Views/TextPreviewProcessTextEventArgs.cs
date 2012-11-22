using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IssueTracker.App.Views
{
    /// <summary>
    /// Event arguments for when the TextPreviewView needs text processed
    /// for rendering to the preview web browser.
    /// </summary>
    internal sealed class TextPreviewProcessTextEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the TextPreviewProcessTextEventArgs class.
        /// </summary>
        /// <param name="text">The text to process.</param>
        public TextPreviewProcessTextEventArgs(string text)
        {
            this.Text = text;
            this.ProcessedText = text;
        }

        /// <summary>
        /// Gets the text which the user entered in.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets or sets the processed text for displaying in a web-browser.
        /// </summary>
        public string ProcessedText { get; set; }
    }
}
