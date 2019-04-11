using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Extensions
{
    /// <summary>
    /// A class for extensions related to the Console static class.
    /// </summary>
    public static class ConsoleKeyInfoExtensions
    {
        /// <summary>
        /// Checks if is a number key, default or NumPad.
        /// </summary>
        /// <param name="keyInfo">The ConsoleKeyInfo</param>
        /// <returns>True if it is a number key</returns>
        public static bool IsNumber(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            // Numbers on top of letters
            if (keyCode >= 48 && keyCode < 58)
                return true;

            // NumPad numbers
            if (keyCode >= 96 && keyCode < 106)
                return true;

            return false;
        }

        /// <summary>
        /// Checks if is a Latin alphabet letter from A to Z.
        /// </summary>
        /// <param name="keyInfo">The ConsoleKeyInfo</param>
        /// <returns>True if it is a letter key</returns>
        public static bool IsLetter(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            if (keyCode >= 65 && keyCode < 91)
                return true;

            return false;
        }

        /// <summary>
        /// Checks if is an arrow.
        /// </summary>
        /// <param name="keyInfo">The ConsoleKeyInfo</param>
        /// <returns>True if it is an arrow key</returns>
        public static bool IsArrowKey(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            if (keyCode >= 37 && keyCode < 41)
                return true;

            return false;
        }

        /// <summary>
        /// Checks if is a Function key, such as F10.
        /// </summary>
        /// <param name="keyInfo">The ConsoleKeyInfo</param>
        /// <returns>True if it is a function key</returns>
        public static bool IsFunctionKey(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            if (keyCode >= 112 && keyCode < 136)
                return true;

            return false;
        }
    }
}
