using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Stack
    {
        NodeOfStack head = null;

        public void Push(object value)
        {
            NodeOfStack node = new NodeOfStack(value);
            node.Next = head;
            head = node;
        }

        public void Pop()
        {
            head = head.Next;
        }

        public object Get()
        {
            object value;
            if (head != null)
            {
                value = head.Value;
                head = head.Next;
            }
            else
                value = null;

            return value;
        }
    }
}
