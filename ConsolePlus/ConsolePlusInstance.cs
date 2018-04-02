using ConsolePlus.Exceptions;
using ConsolePlus.Extensions;
using ConsolePlus.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlus
{
    public class ConsolePlusInstance : IConsole
    {
        #region Properties

        ConsoleQueue block;

        public string Title => Console.Title;

        public int WindowWidth { get { return Console.WindowWidth; } set { Console.WindowWidth = value; } }
        public int WindowHeight { get { return Console.WindowHeight; } set { Console.WindowHeight = value; } }
        public int WindowLeft { get { return Console.WindowLeft; } set { Console.WindowLeft = value; } }
        public int WindowTop { get { return Console.WindowTop; } set { Console.WindowTop = value; } }

        public ConsoleColor BackgroundColor { get { return Console.BackgroundColor; } set { Console.BackgroundColor = value; } }
        public ConsoleColor ForegroundColor { get { return Console.ForegroundColor; } set { Console.ForegroundColor = value; } }

        public uint MaxHistorySize { get; set; } = 50;

        Queue<string> history;
        int historyIndex;

        StringBuilder input;
        InputInterruption interruptInput;

        #endregion

        #region Events

        public event EventHandler<KeyPressEventArgs> OnKeyPressed;

        #endregion

        #region Public methods

        public ConsolePlusInstance()
        {
            interruptInput = InputInterruption.None;
            history = new Queue<string>();
            historyIndex = -1;
            input = new StringBuilder();

            SetTheme(ConsolePlusTheme.Default);
        }

        public ConsoleKeyInfo ReadKey()
        {
            return ReadKey(false);
        }

        public ConsoleKeyInfo ReadKey(bool intercept)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (OnKeyPressed != null)
            {
                KeyPressEventArgs evt = new KeyPressEventArgs() { KeyInfo = keyInfo };
                var handler = OnKeyPressed;
                if (handler != null)
                    OnKeyPressed(this, evt);
            }

            if (!intercept || interruptInput > 0)
                ExecuteKeyAction(keyInfo);

            return keyInfo;
        }

        public string ReadLine()
        {
            ConsoleKeyInfo key;
            do
            {
                key = ReadKey();
            }
            while (interruptInput == InputInterruption.None);

            if (interruptInput == InputInterruption.Natural)
            {
                return ReadAndResetInput();
            }
            else
            {
                ResetInput();
                throw new InterruptedInputException();
            }
        }

        // [ToDo]
        public string ReadAutoComplete(string[] options, bool restrictToOptions = false)
        {
            SortedSet<string> sortedOptions = new SortedSet<string>(options);

            return string.Empty;
        }

        // [ToDo]
        public string ReadSecret()
        {
            return string.Empty;
        }

        // [Update]
        public void Write(char character)
        {
            Console.Write(character);
        }

        // [Update]
        public void Write(string text)
        {
            Console.Write(text);
        }

        // [Update]
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void SetWindowSize(int width, int height)
        {
            Console.SetWindowSize(width, height);
        }

        public void SetTheme(ConsolePlusTheme theme)
        {
            BackgroundColor = theme.BackgroundColor;
            ForegroundColor = theme.ForegroundColor;
        }

        #endregion

        #region Private methods

        // [Update]
        protected void ExecuteKeyAction(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.IsLetter() || keyInfo.IsNumber() || keyInfo.Key == ConsoleKey.Spacebar)
            {
                Console.Write(keyInfo.KeyChar);
                input.Append(keyInfo.KeyChar);
            }
            else if (keyInfo.IsArrowKey())
            {
                Console.Write(keyInfo.Key);
            }
            else
            {
                Console.Write(keyInfo.Key);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Home:

                        break;

                    case ConsoleKey.End:

                        break;

                    case ConsoleKey.Enter:
                        interruptInput = InputInterruption.Natural;
                        break;

                    case ConsoleKey.Escape:
                        interruptInput = InputInterruption.Forced;
                        break;
                }
            }

            Console.Write(" ");

            UpdateConsole();
        }

        // [ToDo]
        private void UpdateConsole()
        {
            // should update the text on screen according to the input
        }

        protected string ReadAndResetInput()
        {
            string result = input.ToString();
            EnqueueHistory(result);
            ResetInput();
            return result;
        }

        protected void ResetInput()
        {
            input = new StringBuilder();
        }

        protected void EnqueueHistory(string historyItem)
        {
            history.Enqueue(historyItem);
            if (history.Count > MaxHistorySize)
                history.Dequeue();

            historyIndex = history.Count - 1;
        }

        #endregion
    }

    public enum InputInterruption
    {
        None = 0,
        Natural = 1,
        Forced = 2
    }
}
