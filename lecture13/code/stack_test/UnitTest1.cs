using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stack_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1_TheStackExists()
        {
            // There should be a class Stack
            MyStack s = new MyStack();
            Assert.IsNotNull(s);
        }

        [TestMethod]
        public void Test_2_NewStackIsEmpty()
        {
            // should be that a new stack is empty
            MyStack s = new MyStack();
            Assert.AreEqual(s.Empty(), true);
        }

        [TestMethod]
        public void Test_3_CanPush()
        {
            // should be possible to push an element on the stack
            MyStack s = new MyStack();
            try
            {
                s.Push(5);
            }
            catch (Exception)
            {
                throw new Exception("Push not implemented");
            }
        }

        [TestMethod]
        public void Test_4_NotEmptyAfterPush()
        {
            // should be false that a stack is empty, after pushing an element
            MyStack s = new MyStack();
            s.Push(5);
            Assert.AreEqual(s.Empty(), false);
        }

        [TestMethod]
        public void Test_5_LIFO()
        {
            // should be that the element popped from a stack is the last pushed
            MyStack s = new MyStack();
            s.Push(123);
            int popped = s.Pop();
            Assert.AreEqual(popped, 123);
        }

        [TestMethod]
        public void Test_6_CannotPopEmptyStack()
        {
            // pop an empty stack should throw an exception
            MyStack s = new MyStack();
            try
            {
                int popped = s.Pop();
                Assert.Fail("Expected exception");
            }
            catch (Exception)
            {
                // Expected
                // ... everything fine, just continue ...
            }

        }

        [TestMethod]
        public void Test_7_PushPopThenEmpty()
        {
            // should be that pushing and popping an element on a new stack, makes the stack empty
            MyStack s = new MyStack();
            s.Push(123);
            int popped = s.Pop();
            Assert.IsTrue(s.Empty());
        }

        [TestMethod]
        public void Test_8_ElementsComeBackInverted()
        {
            // should be that pushing two elements a and b on the stack and then popping twice, the elements come back inverted
            int a = 1;
            int b = 2;

            MyStack s = new MyStack();
            s.Push(a); s.Push(b);
            int c = s.Pop();
            int d = s.Pop();
            Assert.AreEqual(a, d);
            Assert.AreEqual(b, c);
        }

        [TestMethod]
        public void Test_9_CanPrintMyStack()
        {
            // should be possible to print the stack
            MyStack s = new MyStack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreNotEqual(s.ToString(), "");
        }

    }
}
