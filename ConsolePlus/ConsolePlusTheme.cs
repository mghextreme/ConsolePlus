using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus
{
    /// <summary>
    /// A color theme for the console.
    /// </summary>
    public class ConsolePlusTheme : IComparable, IComparable<ConsolePlusTheme>, IEquatable<ConsolePlusTheme>
    {
        public ConsoleColor ForegroundColor { get; set; }

        public ConsoleColor BackgroundColor { get; set; }

        #region Interfaces

        public int CompareTo(object obj)
        {
            var cpt = obj as ConsolePlusTheme;
            if (cpt == null)
                return 1;
            
            return CompareTo(cpt);
        }

        public int CompareTo(ConsolePlusTheme other)
        {
            int foreCompare = BackgroundColor.CompareTo(other.BackgroundColor);
            if (foreCompare != 0)
                return foreCompare;
            
            return ForegroundColor.CompareTo(other.ForegroundColor);
        }

        public bool Equals(ConsolePlusTheme other)
        {
            return CompareTo(other) == 0;
        }

        #endregion

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
