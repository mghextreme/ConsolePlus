using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsolePlus.Extensions;

namespace ConsolePlus.Test
{
    [TestClass]
    public class ConsoleKeyExtensionTest
    {
        [TestMethod]
        public void ConsoleKey_Number()
        {
            ConsoleKeyInfo keyInfo0 = new ConsoleKeyInfo('0', ConsoleKey.D0, false, false, false);
            Assert.IsTrue(keyInfo0.IsNumber());
            Assert.IsFalse(keyInfo0.IsLetter());
            Assert.IsFalse(keyInfo0.IsArrowKey());
            Assert.IsFalse(keyInfo0.IsFunctionKey());

            ConsoleKeyInfo keyInfo1 = new ConsoleKeyInfo('1', ConsoleKey.D1, false, false, false);
            Assert.IsTrue(keyInfo1.IsNumber());
            Assert.IsFalse(keyInfo1.IsLetter());
            Assert.IsFalse(keyInfo1.IsArrowKey());
            Assert.IsFalse(keyInfo1.IsFunctionKey());

            ConsoleKeyInfo keyInfo9 = new ConsoleKeyInfo('9', ConsoleKey.D9, false, false, false);
            Assert.IsTrue(keyInfo9.IsNumber());
            Assert.IsFalse(keyInfo9.IsLetter());
            Assert.IsFalse(keyInfo9.IsArrowKey());
            Assert.IsFalse(keyInfo9.IsFunctionKey());

            ConsoleKeyInfo keyInfoShift5 = new ConsoleKeyInfo('%', ConsoleKey.D5, true, false, false);
            Assert.IsFalse(keyInfoShift5.IsNumber());
        }

        [TestMethod]
        public void ConsoleKey_Letter()
        {
            ConsoleKeyInfo keyInfoA = new ConsoleKeyInfo('a', ConsoleKey.A, false, false, false);
            Assert.IsFalse(keyInfoA.IsNumber());
            Assert.IsTrue(keyInfoA.IsLetter());
            Assert.IsFalse(keyInfoA.IsArrowKey());
            Assert.IsFalse(keyInfoA.IsFunctionKey());

            ConsoleKeyInfo keyInfoZ = new ConsoleKeyInfo('z', ConsoleKey.Z, false, false, false);
            Assert.IsFalse(keyInfoZ.IsNumber());
            Assert.IsTrue(keyInfoZ.IsLetter());
            Assert.IsFalse(keyInfoZ.IsArrowKey());
            Assert.IsFalse(keyInfoZ.IsFunctionKey());

            ConsoleKeyInfo keyInfoShiftF = new ConsoleKeyInfo('F', ConsoleKey.F, true, false, false);
            Assert.IsFalse(keyInfoShiftF.IsNumber());
            Assert.IsTrue(keyInfoShiftF.IsLetter());
            Assert.IsFalse(keyInfoShiftF.IsArrowKey());
            Assert.IsFalse(keyInfoShiftF.IsFunctionKey());
        }

        [TestMethod]
        public void ConsoleKey_Arrows()
        {
            ConsoleKeyInfo keyInfoLeft = new ConsoleKeyInfo(char.MinValue, ConsoleKey.LeftArrow, false, false, false);
            Assert.IsFalse(keyInfoLeft.IsNumber());
            Assert.IsFalse(keyInfoLeft.IsLetter());
            Assert.IsTrue(keyInfoLeft.IsArrowKey());
            Assert.IsFalse(keyInfoLeft.IsFunctionKey());

            ConsoleKeyInfo keyInfoRight = new ConsoleKeyInfo(char.MinValue, ConsoleKey.RightArrow, false, false, false);
            Assert.IsFalse(keyInfoRight.IsNumber());
            Assert.IsFalse(keyInfoRight.IsLetter());
            Assert.IsTrue(keyInfoRight.IsArrowKey());
            Assert.IsFalse(keyInfoRight.IsFunctionKey());

            ConsoleKeyInfo keyInfoUp = new ConsoleKeyInfo(char.MinValue, ConsoleKey.UpArrow, false, false, false);
            Assert.IsFalse(keyInfoUp.IsNumber());
            Assert.IsFalse(keyInfoUp.IsLetter());
            Assert.IsTrue(keyInfoUp.IsArrowKey());
            Assert.IsFalse(keyInfoUp.IsFunctionKey());

            ConsoleKeyInfo keyInfoDown = new ConsoleKeyInfo(char.MinValue, ConsoleKey.DownArrow, false, false, false);
            Assert.IsFalse(keyInfoDown.IsNumber());
            Assert.IsFalse(keyInfoDown.IsLetter());
            Assert.IsTrue(keyInfoDown.IsArrowKey());
            Assert.IsFalse(keyInfoDown.IsFunctionKey());
        }

        [TestMethod]
        public void ConsoleKey_FunctionKeys()
        {
            ConsoleKeyInfo keyInfoLeft = new ConsoleKeyInfo(char.MinValue, ConsoleKey.F1, false, false, false);
            Assert.IsFalse(keyInfoLeft.IsNumber());
            Assert.IsFalse(keyInfoLeft.IsLetter());
            Assert.IsFalse(keyInfoLeft.IsArrowKey());
            Assert.IsTrue(keyInfoLeft.IsFunctionKey());

            ConsoleKeyInfo keyInfoRight = new ConsoleKeyInfo(char.MinValue, ConsoleKey.F12, false, false, false);
            Assert.IsFalse(keyInfoRight.IsNumber());
            Assert.IsFalse(keyInfoRight.IsLetter());
            Assert.IsFalse(keyInfoRight.IsArrowKey());
            Assert.IsTrue(keyInfoRight.IsFunctionKey());

            ConsoleKeyInfo keyInfoUp = new ConsoleKeyInfo(char.MinValue, ConsoleKey.F24, false, false, false);
            Assert.IsFalse(keyInfoUp.IsNumber());
            Assert.IsFalse(keyInfoUp.IsLetter());
            Assert.IsFalse(keyInfoUp.IsArrowKey());
            Assert.IsTrue(keyInfoUp.IsFunctionKey());
        }
    }
}