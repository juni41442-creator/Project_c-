using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Class
{
   class Customer
    {
        public string Grade { get; set; }
        public int Money { get; set; }
        public string PreferredItemType { get; set; }

        public Customer(string grade, int initialMoney, string preferredItemType)
        {
            Grade = grade;
            Money = initialMoney;
            PreferredItemType = preferredItemType;
        }

        public int GetPurchasePrice(Item item)
        {
            double priceMultiplier = 1.0;

            if (Grade == "VIP") priceMultiplier *= 1.5;
            else if (Grade == "Gold") priceMultiplier *= 1.2;

            if (item.ItemType == PreferredItemType)
            {
                priceMultiplier *= 1.5; // 선호 아이템
            }
            else
            {
                priceMultiplier *= 0.8; // 비선호 아이템
            }

            return (int)(item.BasePrice * priceMultiplier);
        }

        public bool BuyItem(int price)
        {
            if (Money >= price)
            {
                Money -= price;
                return true;
            }
            return false;
        }
    }
}
