using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TccLib.WinForms.Extensions
{
    /// <summary>
    /// A collection of extension methods for the Control class.
    /// </summary>
    public static class ControlExtensions
    {
        /// <summary>
        /// Attempts to toggle the double-buffering property of a Control.
        /// </summary>
        /// <remarks>Turning on double-buffering will not work for terminal server sessions.</remarks>
        /// <param name="control">The Control to toggle.</param>
        /// <param name="flag">The new toggled value.</param>
        public static void ToggleDoubleBuffering(this Control control, bool flag)
        {
            if (control == null) throw new ArgumentNullException("control");

            if (flag && System.Windows.Forms.SystemInformation.TerminalServerSession) return;

            var lProperty = typeof(Control).GetProperty(
                "DoubleBuffered", 
                System.Reflection.BindingFlags.NonPublic | 
                System.Reflection.BindingFlags.Instance);

            lProperty.SetValue(control, flag, null);
        }
    }
}
