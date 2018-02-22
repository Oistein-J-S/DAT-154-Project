using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    public class Item
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public Item(int value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}
