using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeshop
{
    public class Store
    {
        public int Size { get; set; } // 규모
        public string Event { get; set; } // 이벤트
        public long TotalSales { get; set; } // 총 매출액

        public Store(int size, string eventDescription)
        {
            Size = size;
            Event = eventDescription;
            TotalSales = 0;
        }

        // 매출액 추가 메서드
        public void AddSales(int amount)
        {
            TotalSales += amount;
        }
    }    
}
