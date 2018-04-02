using System;

namespace ConsolePlus
{
    public interface IConsole
    {
        ConsoleKeyInfo ReadKey();
        ConsoleKeyInfo ReadKey(bool intercept);

        string ReadLine();

        string ReadAutoComplete(string[] options, bool restrictToOptions = false);

        string ReadSecret();

        void Write(char character);

        void Write(string text);

        void WriteLine(string text);
    }
}