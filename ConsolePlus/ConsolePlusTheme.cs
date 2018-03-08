using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus
{
    public class ConsolePlusTheme
    {
        public ConsoleColor ForegroundColor { get; set; }

        public ConsoleColor BackgroundColor { get; set; }

        #region Static Themes

        public static ConsolePlusTheme Default
        {
            get
            {
                return new ConsolePlusTheme()
                {
                    BackgroundColor = ConsoleColor.Black,
                    ForegroundColor = ConsoleColor.White
                };
            }
        }

        public static ConsolePlusTheme Terminal
        {
            get
            {
                return new ConsolePlusTheme()
                {
                    BackgroundColor = ConsoleColor.Black,
                    ForegroundColor = ConsoleColor.Green
                };
            }
        }

        public static ConsolePlusTheme Paper
        {
            get
            {
                return new ConsolePlusTheme()
                {
                    BackgroundColor = ConsoleColor.White,
                    ForegroundColor = ConsoleColor.Black
                };
            }
        }

        public static ConsolePlusTheme Aqua
        {
            get
            {
                return new ConsolePlusTheme()
                {
                    BackgroundColor = ConsoleColor.DarkBlue,
                    ForegroundColor = ConsoleColor.Cyan
                };
            }
        }

        public static ConsolePlusTheme Velvet
        {
            get
            {
                return new ConsolePlusTheme()
                {
                    BackgroundColor = ConsoleColor.DarkRed,
                    ForegroundColor = ConsoleColor.White
                };
            }
        }

        #endregion
    }
}
