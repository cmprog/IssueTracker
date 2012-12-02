using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IssueTracker.Data;

namespace IssueTracker.App.Models
{
    internal sealed class IssueModel
    {
        /// <summary>
        /// Initializes a new instance of the IssueModel class.
        /// </summary>
        public IssueModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IssueModel class by populating it with
        /// the values provided by the given Issue.
        /// </summary>
        /// <param name="issue">The Issue to populate the model with.</param>
        public IssueModel(Issue issue)
        {
            this.Id = issue.Id;
            this.Title = issue.Title;
            this.Author = issue.OpenedByUser.FullName;
            this.CreationDate = issue.CreationDate.ToLocalTime();
        }

        /// <summary>
        /// Gets or sets the ID of the issue.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the issue.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the issue.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the issue.
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}
