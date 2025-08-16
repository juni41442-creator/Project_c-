using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeshop
{
    public class Item
    {
        public int Price { get; set; } // 가격
        public string Name { get; set; } // 상품명

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
