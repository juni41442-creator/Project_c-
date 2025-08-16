using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Class
{
    class Item
    {
        public string Name { get; set; }
        public string ItemType { get; set; }
        public int BasePrice { get; set; }

        public Item(string name, string itemType, int basePrice)
        {
            Name = name;
            ItemType = itemType;
            BasePrice = basePrice;
        }
    }
}
