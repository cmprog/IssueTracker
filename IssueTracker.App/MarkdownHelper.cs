using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IssueTracker.App
{
    public static class MarkdownHelper
    {
        public static string TranslateWithStyle(string markdownText)
        {
            var lMarkdown = new MarkdownSharp.Markdown();

            var lStyleSheet = Properties.Resources.PreviewStyleSheet;
            var lHeader = Properties.Settings.Default.MarkdownStyleHeader + lStyleSheet + Properties.Settings.Default.MarkdownBodyHeader;
            var lBody = lMarkdown.Transform(markdownText);
            var lFooter = Properties.Settings.Default.MarkdownBodyFooter;
            return lHeader + lBody + lFooter;
        }
    }
}
