using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Tree
    {
        NodeOfTree Root { get; set; }

        public Tree ()
        {
            Root = null;
        }

        public void Insert (string word)
        {
            Root = Add(Root, word);
        }

        NodeOfTree Add (NodeOfTree node, string word)
        {
            if (node == null)
            {
                node = new NodeOfTree(word);
            }
            else
            {
                int res = string.Compare(node.Str, word);
                if (res == 0)
                    node.Amount++;
                else if (res == -1)
                    node.Left = Add(node, word);
                else if (res == 1)
                    node.Right = Add(node, word);
            }

            return node;
        }
    }
}
