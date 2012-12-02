using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IssueTracker.Data
{
    public partial class User
    {
        /// <summary>
        /// Gets the full name of the user.
        /// </summary>
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
    }
}
