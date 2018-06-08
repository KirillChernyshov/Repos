using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Query
    {
        public string Criterion { get; set; }
        public string Value { get; set; }
        public int Priority { get; set; }

        public Query(string criterion, string value, int priority)
        {
            Criterion = criterion;
            Value = value;
            Priority = priority;
        }
    }
}
