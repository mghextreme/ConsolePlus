using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Graphics
{
    /// <summary>
    /// A single block of text that contains at least one character.
    /// </summary>
    public class ConsoleText
    {
        public string Content { get; set; }
        public ConsolePlusTheme Theme { get; set; }
        public ConsoleColor BackgroundColor
        {
            get
            {
                return Theme.BackgroundColor;
            }
            set
            {
                Theme.BackgroundColor = value;
            }
        }
        public ConsoleColor ForegroundColor
        {
            get
            {
                return Theme.ForegroundColor;
            }
            set
            {
                Theme.ForegroundColor = value;
            }
        }

        public ConsoleText()
        {

        }

        public ConsoleText(string content)
        {
            Content = content;
        }

        public ConsoleText(string content, ConsolePlusTheme theme) : this(content)
        {
            Theme = theme;
        }
    }
}
