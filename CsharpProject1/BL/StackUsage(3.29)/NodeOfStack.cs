using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class NodeOfStack
    {
        public object Value { get; set; }
        public NodeOfStack Next { get; set; }

        public NodeOfStack(object value)
        {
            Value = value;
        }
    }
}
