using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccLib.WinForms
{
    public static class GenericWrapper
    {
        /// <summary>
        /// Creates a new generic wrapper with the given value and string generator.
        /// </summary>
        /// <typeparam name="TValue">The type of the wrapped value.</typeparam>
        /// <param name="value">The value to wrap.</param>
        /// <param name="toString">A string generator for the given type.</param>
        /// <returns>The wrapped value.</returns>
        public static GenericWrapper<TValue> Create<TValue>(TValue value, Func<TValue, string> toString) where TValue : class
        {
            return new GenericWrapper<TValue>(value, toString);
        }
    }

    /// <summary>
    /// Provides a genericly typped wrapper around an object. This becomes very userful for providing
    /// wrapers around objects used by WinForms controls such as combo boxes and list boxes and providing
    /// customized ToString implmementations.
    /// </summary>
    public sealed class GenericWrapper<TValue> where TValue : class
    {
        /// <summary>
        /// Initializes a new instance of the GenericWrapper class.
        /// </summary>
        /// <param name="value">The value to wrap.</param>
        public GenericWrapper(TValue value)
            : this(value, x => x.ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the GenericWrapper class.
        /// </summary>
        /// <param name="item">The value to wrap.</param>
        /// <param name="toString">A function used to get a string representation of the item.</param>
        public GenericWrapper(TValue value, Func<TValue, string> toString)
        {
            if (toString == null) throw new ArgumentNullException("toString");

            this.Value = value;
            this.StringGenerator = toString;
        }

        /// <summary>
        /// Gets or sets the string generator function for getting the representation
        /// of the item.
        /// </summary>
        private Func<TValue, string> StringGenerator { get; set; }

        /// <summary>
        /// Gets the wrapped value.
        /// </summary>
        public TValue Value { get; private set; }

        /// <summary>
        /// Gets a string representation of this wrapper.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.StringGenerator(this.Value);
        }

        /// <summary>
        /// Checks of this wrapper is equal to the given object. True
        /// if the object is equal to the value wrapped by this wrapper
        /// or if the value is a wrapper wrapping a value equal to the value
        /// wrapped by this wrapper.
        /// </summary>
        /// <param name="obj">The object we're comparing against.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (ReferenceEquals(this.Value, obj)) return true;

            var lObjectAsWrapper = obj as GenericWrapper<TValue>;
            if (lObjectAsWrapper != null)
            {
                return object.Equals(this.Value, lObjectAsWrapper.Value);
            }

            var lObjectAsValue = obj as TValue;
            if (lObjectAsValue != null)
            {
                return object.Equals(this.Value, lObjectAsValue);
            }

            return false;
        }

        /// <summary>
        /// Gets a hash code for the wrapper. The hash code will
        /// be the hash code of the wrapped value.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (this.Value == null) ? 0 : this.Value.GetHashCode();
        }

        /// <summary>
        /// Unwraps the given raw value.
        /// </summary>
        /// <param name="rawValue">The raw value to unwrap.</param>
        /// <returns>The unwrapped value.</returns>
        public static TValue UnWrap(object rawValue)
        {
            var lWrapper = rawValue as GenericWrapper<TValue>;
            if (lWrapper == null)
            {
                throw new ArgumentException(
                   "Cannot unwrap something that is not wrapped with a GenericWraper.", "rawValue");
            }

            return lWrapper.Value;
        }
    }
}
