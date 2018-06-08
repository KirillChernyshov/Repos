using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class NodeOfTree
    {
        public string Str { get; set; }
        public int Amount { get; set; }
        public NodeOfTree Left { get; set; }
        public NodeOfTree Right { get; set; }

        public NodeOfTree (string str)
        {
            Str = str;
            Amount = 1;
        }

    }
}
