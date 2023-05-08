using System;

namespace Stack_test
{
    public class MyStack
    {
        private Cell elements;

        public MyStack()
        {
            this.elements = null;
        }

        public bool Empty()
        {
            if (elements == null)
            {
                return true;
            }
            return false;
        }

        public int Pop()
        {
            if (Empty())
            {
                throw new Exception("Cannot pop from an empty stack");
            }

            int popped = elements.value; // from the head of the "list"
            elements = elements.next;    // cut the head and shorten the "list"
            return popped;
        }

        public void Push(int n)
        {
            Cell temp = new Cell(n,elements);
            elements = temp;
        }

        public override string ToString()
        {
            string stackString = "Top->(";
            Cell top = elements;
            while (top != null)
            {
                stackString += top.value + " ";
                top = top.next;
            }
            stackString += ")";
            return stackString;
        }
    }

    public class Cell
    {
        public int value;
        public Cell next;

        public Cell(int value, Cell next=null)
        {
            this.value = value;
            this.next = next;
        }
    }
}
