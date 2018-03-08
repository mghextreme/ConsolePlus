using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Extensions
{
    public static class ConsoleKeyInfoExtensions
    {
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

        public static bool IsLetter(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            if (keyCode >= 65 && keyCode < 91)
                return true;

            return false;
        }

        public static bool IsArrowKey(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            if (keyCode >= 37 && keyCode < 41)
                return true;

            return false;
        }

        public static bool IsFunctionKey(this ConsoleKeyInfo keyInfo)
        {
            int keyCode = (int)keyInfo.Key;

            if (keyCode >= 112 && keyCode < 136)
                return true;

            return false;
        }
    }
}
