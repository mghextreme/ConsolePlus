using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus
{
    public class KeyPressEventArgs : EventArgs
    {
        public ConsoleKeyInfo KeyInfo { get; set; }
    }
}
