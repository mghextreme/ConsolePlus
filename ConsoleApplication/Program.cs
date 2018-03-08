using ConsolePlus;
using ConsolePlus.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static ConsolePlusInstance console;

        static void Main(string[] args)
        {
            console = new ConsolePlusInstance();
            console.OnKeyPressed += ChangeTheme;

            ConsoleKeyInfo key;
            do
            {
                key = console.ReadKey(false);

                switch ((int)key.Key)
                {
                    case 49: console.SetTheme(ConsolePlusTheme.Default); break;
                    case 50: console.SetTheme(ConsolePlusTheme.Terminal); break;
                    case 51: console.SetTheme(ConsolePlusTheme.Paper); break;
                    case 52: console.SetTheme(ConsolePlusTheme.Aqua); break;
                    case 53: console.SetTheme(ConsolePlusTheme.Velvet); break;
                }
            }
            while (key.Key != ConsoleKey.Enter);
        }

        static void ChangeTheme(object sender, KeyPressEventArgs e)
        {
            if (e.KeyInfo.IsNumber())
                console.SetTheme(ConsolePlusTheme.Terminal);
            else if (e.KeyInfo.IsLetter())
                console.SetTheme(ConsolePlusTheme.Paper);
            else if (e.KeyInfo.IsFunctionKey())
                console.SetTheme(ConsolePlusTheme.Velvet);
            else if (e.KeyInfo.IsArrowKey())
                console.SetTheme(ConsolePlusTheme.Aqua);
            else
                console.SetTheme(ConsolePlusTheme.Default);
        }
    }
}
