using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus.Graphics
{
    /// <summary>
    /// A queue of ConsoleLine instances to be shown in the console.
    /// </summary>
    public class ConsoleQueue
    {
        protected ICollection<ConsoleLine> lines;

        protected ConsoleLine CurrentLine;

        public ConsoleQueue()
        {
            CurrentLine = new ConsoleLine();
            lines.Add(CurrentLine);
        }

        public void Append(string content)
        {
            CurrentLine.Append(content);
        }

        public void Append(string content, ConsolePlusTheme theme)
        {
            CurrentLine.Append(content, theme);
        }

        public void Append(ConsoleText content)
        {
            CurrentLine.Append(content);
        }

        public void Append(ConsoleLine line)
        {
            CurrentLine = line;
            lines.Add(CurrentLine);
        }

        public void NewLine(ConsoleLine line)
        {
            CurrentLine = new ConsoleLine();
            lines.Add(CurrentLine);
        }
    }
}
