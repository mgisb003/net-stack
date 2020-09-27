using net_stack.exceptions;
using net_stack.model.exceptions;
using System;
using EmptyStackException = net_stack.exceptions.EmptyStackException;

namespace net_stack
{
    public class Node
    {
        public Node(object value, Node next)
        {
            Value = value;
            Next = next;
        }

        public object Value { get; private set; }
        public Node Next { get; set; }

    }
    public class Stack
    {

        private Node head;
        object obj;
        private int size = 0;
        public bool isEmpty()
        {
            return head == null;
        }

        public void push(object o)
        {
            size++;
            Node node = new Node(o, null);
            node.Next = head;
            head = node;
        }

        public object peek()
        {
            if (isEmpty())
            {
                return null;
            }
            return 1;
        }

        public object pop()
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

