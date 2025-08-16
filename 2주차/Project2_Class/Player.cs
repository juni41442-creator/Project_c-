using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Class
{
    class Player
    {
        public int Money { get; set; }
        public int DebtDueDate { get; set; }
        public Dictionary<int, Customer> MetCustomers { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(int initialMoney, int debtDueDate)
        {
            Money = initialMoney;
            DebtDueDate = debtDueDate;
            MetCustomers = new Dictionary<int, Customer>();
            Inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"플레이어가 '{item.Name}' 아이템을 획득했습니다.");
        }

        public void SellItem(string itemName, int customerId)
        {
            if (!MetCustomers.ContainsKey(customerId))
            {
                Console.WriteLine("❗ 해당 고객을 찾을 수 없습니다.");
                return;
            }

            Customer customer = MetCustomers[customerId];
            Item itemToSell = Inventory.Find(item => item.Name == itemName);

            if (itemToSell == null)
            {
                Console.WriteLine("❗ 해당 아이템을 소지하고 있지 않습니다.");
                return;
            }

            int sellingPrice = customer.GetPurchasePrice(itemToSell);

            if (customer.BuyItem(sellingPrice))
            {
                Money += sellingPrice;
                Inventory.Remove(itemToSell);
                Console.WriteLine($"✅ '{itemToSell.Name}'을(를) {customer.Grade} 등급 고객에게 {sellingPrice}원에 판매했습니다.");
                Console.WriteLine($"현재 소지금: {Money}");
            }
            else
            {
                Console.WriteLine("❗ 고객의 소지금이 부족하여 판매에 실패했습니다.");
            }
        }
    }
}
