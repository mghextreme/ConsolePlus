using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Graphics
{
    public class ConsoleText
    {
        public string Content { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor ForegroundColor { get; set; }

        public ConsoleText()
        {

        }

        public ConsoleText(string content)
        {
            Content = content;
        }
    }
}
