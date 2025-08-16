using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeshop
{
    public class Player
    {
        public int Capital { get; set; } // 자본금
        public int Recognition { get; set; } // 인지도
        public List<Item> Inventory { get; set; } // 아이템 인벤토리

        public Player(int initialCapital, int initialRecognition)
        {
            Capital = initialCapital;
            Recognition = initialRecognition;
            Inventory = new List<Item>();
        }

        // 아이템 구매 메서드
        public void BuyItem(Item item)
        {
            if (Capital >= item.Price)
            {
                Capital -= item.Price;
                Inventory.Add(item);
                Console.WriteLine($"{item.Name}을(를) 구매했습니다. 남은 자본금: {Capital}");
            }
            else
            {
                Console.WriteLine("자본금이 부족합니다.");
            }
        }
    }

}
