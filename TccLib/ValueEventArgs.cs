using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccLib
{
    /// <summary>
    /// Helper creation methods for the ValueEventArgs{TValue} class.
    /// </summary>
    public static class ValueEventArgs
    {
        /// <summary>
        /// Creates and returns a new instance of the ValueEventArgs class.
        /// </summary>
        /// <typeparam name="TValue">The Type of the value wrapped by the evnet arguments.</typeparam>
        /// <param name="value">The value to wrap by the event arguments.</param>
        /// <returns>The newly created instance of the ValueEventArgs.</returns>
        public static ValueEventArgs<TValue> Create<TValue>(TValue value)
        {
            return new ValueEventArgs<TValue>(value);
        }
    }

    /// <summary>
    /// Simple event arguments which can be used when a value needs to be
    /// fetched from an event handler.
    /// </summary>
    /// <typeparam name="TValue">The type of the value to wrap.</typeparam>
    public sealed class ValueEventArgs<TValue> : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the ValueEventArgs class.
        /// </summary>
        public ValueEventArgs()
            : this(default(TValue))
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueEventArgs class.
        /// </summary>
        /// <param name="value">The value to contain.</param>
        public ValueEventArgs(TValue value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the value contained by the event arguments.
        /// </summary>
        public TValue Value { get; set; }
    }
}
