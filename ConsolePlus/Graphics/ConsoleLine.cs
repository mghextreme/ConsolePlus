using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Graphics
{
    /// <summary>
    /// A single line of text formed by ConsoleText instances.
    /// </summary>
    public class ConsoleLine
    {
        protected ICollection<ConsoleText> lines;
        public ConsolePlusTheme CurrentTheme { get; set; }

        public void Append(string content)
        {
            Append(content, CurrentTheme);
        }

        public void Append(string content, ConsolePlusTheme theme)
        {
            Append(new ConsoleText(content, theme));
        }

        public void Append(ConsoleText content)
        {
            lines.Add(content);
        }
    }
}
