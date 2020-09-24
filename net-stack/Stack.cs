using net_stack.exceptions;
using System;
namespace net_stack
{

    public class Stack
  {
        private Node head = null;

        public bool isEmpty()
        {
            return head == null;
        }

        public void push(object o)
        {
            Node node = new Node(o, null);
            node.Next = head;
            head = node;
        }

        public string peek()
        {
            if (isEmpty())
            {
                return null;
            }
            return "abc";
        }

        public Object pop()
        {
            if (isEmpty())
            {
                throw new EmptyStackException("");
            }
            object temp = head.Value;
            head = head.Next;
            return temp;
        }

        public bool contains(object o)
        {
            Node iterator = head;
            while (iterator != null)
            {
                if (iterator.Value == o)
                {
                    return true;
                }
                iterator = iterator.Next;
            }

            return false;

        }
    }
}
