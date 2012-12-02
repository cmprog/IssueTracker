using System;
using System.Linq;

namespace IssueTracker.Data
{
    partial class IssueTrackerDataContext
    {
        private Lazy<User> mLazyCurrentUser;

        /// <summary>
        /// Initializes the partial class state of the data context.
        /// </summary>
        partial void OnCreated()
        {
            this.mLazyCurrentUser = new Lazy<User>(this.LoadCurrentUser);
        }

        /// <summary>
        /// Gets the current User.
        /// </summary>
        public User CurrentUser
        {
            get { return this.mLazyCurrentUser.Value; }
        }

        /// <summary>
        /// Loads the current user.
        /// </summary>
        /// <returns>The current user.</returns>
        private User LoadCurrentUser()
        {
            return this.Users.Single(x => x.Username == Environment.UserName);
        }
    }
}
