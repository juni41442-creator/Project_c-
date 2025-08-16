using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeshop
{
    public class Customer
    {
        public int Grade { get; set; } // 등급
        public int Cash { get; set; } // 소지금
        public Dictionary<string, int> Preferences { get; set; } // 아이템 선호도 (아이템명, 선호도 점수)

        public Customer(int grade, int cash)
        {
            Grade = grade;
            Cash = cash;
            Preferences = new Dictionary<string, int>();
        }

        // 아이템 선호도 설정 메서드
        public void SetPreference(string itemName, int preferenceValue)
        {
            Preferences[itemName] = preferenceValue;
        }

        // 아이템 구매 가능 여부 확인
        public bool CanAfford(int itemPrice)
        {
            return Cash >= itemPrice;
        }
    }
}
