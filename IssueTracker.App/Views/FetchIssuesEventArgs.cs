using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IssueTracker.App.Models;

namespace IssueTracker.App.Views
{
    /// <summary>
    /// Defines the set of filters which can be used for custom fetch requests.
    /// </summary>
    internal enum FetchIssueFilter
    {
        AssignedToUser,
        CreatedByUser,
        All,
    }

    internal enum FetchIssueStatus
    {
        Open,
        Closed
    }

    /// <summary>
    /// Defines a set of event arguments used to fetch event arguments.
    /// </summary>
    internal sealed class FetchIssuesEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of the FetchIssuesEventArgs class.
        /// </summary>
        /// <param name="filter">The filter for the fetch request.</param>
        /// <param name="searchText">The search text.</param>
        public FetchIssuesEventArgs(FetchIssueFilter filter, FetchIssueStatus status, string searchText)
        {
            if (searchText == null) throw new ArgumentNullException("searchText");

            this.SearchText = searchText;
            this.Filter = filter;
            this.Status = status;
            this.Results = Enumerable.Empty<IssueModel>();
        }

        /// <summary>
        /// Gets the search text the user provided.
        /// </summary>
        public string SearchText { get; private set; }

        /// <summary>
        /// Gets the FetchIssueFilter to use to filter the fetch results.
        /// </summary>
        public FetchIssueFilter Filter { get; private set; }

        /// <summary>
        /// Gets the FetchIssueState to use to filter the fetch results.
        /// </summary>
        public FetchIssueStatus Status { get; private set; }

        /// <summary>
        /// Gets or sets the results of the fetch request.
        /// </summary>
        public IEnumerable<IssueModel> Results { get; set; }
    }
}
