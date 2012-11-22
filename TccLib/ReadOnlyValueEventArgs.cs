using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccLib
{
    public static class ReadOnlyValueEventArgs
    {
        /// <summary>
        /// Creates a new instance of the ReadOnlyValueEventArgs class.
        /// </summary>
        /// <typeparam name="TValue">The type of the value being passed by the event.</typeparam>
        /// <param name="value">The value associated with the event.</param>
        /// <returns>The event arguments container the value.</returns>
        public static ReadOnlyValueEventArgs<TValue> Create<TValue>(TValue value)
        {
            return new ReadOnlyValueEventArgs<TValue>(value);
        }
    }

    /// <summary>
    /// A generic container for a single value being passed as event arguments.
    /// </summary>
    public sealed class ReadOnlyValueEventArgs<TValue> : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the ReadOnlyValueEventArgs class.
        /// </summary>
        /// <param name="value">The value being contained.</param>
        public ReadOnlyValueEventArgs(TValue value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the value associated with the event.
        /// </summary>
        public TValue Value { get; private set; }
    }
}
