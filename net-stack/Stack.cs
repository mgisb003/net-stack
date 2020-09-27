<<<<<<< Updated upstream
﻿using net_stack.exceptions;
=======
﻿using net_stack.model.exceptions;
>>>>>>> Stashed changes
using System;
namespace net_stack
{

<<<<<<< Updated upstream
    public class Stack
  {
        private Node head = null;

=======
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
>>>>>>> Stashed changes
        public bool isEmpty()
        {
            return head == null;
        }

        public void push(object o)
        {
<<<<<<< Updated upstream
=======
            size++;
>>>>>>> Stashed changes
            Node node = new Node(o, null);
            node.Next = head;
            head = node;
        }

<<<<<<< Updated upstream
        public string peek()
=======
        public object peek()
>>>>>>> Stashed changes
        {
            if (isEmpty())
            {
                return null;
<<<<<<< Updated upstream
            }
            return "abc";
        }

        public Object pop()
=======
            }       
            return head.Value;
        }

        public object pop()
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            Node iterator = head;
            while (iterator != null)
            {
                if (iterator.Value == o)
=======

            Node iterator = head;
            while(iterator != null)
            {
                if(iterator.Value == o)
>>>>>>> Stashed changes
                {
                    return true;
                }
                iterator = iterator.Next;
            }
<<<<<<< Updated upstream

            return false;

        }
=======
            return false;
        }

>>>>>>> Stashed changes
    }
}
