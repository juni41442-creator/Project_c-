using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeshop
{
    public class Goal
    {
        public int DurationInDays { get; set; } // 기간 (일 단위)
        public long TargetSales { get; set; } // 목표 매출액
        public bool IsAchieved { get; private set; } // 달성 여부

        public Goal(int duration, long target)
        {
            DurationInDays = duration;
            TargetSales = target;
            IsAchieved = false;
        }

        // 목표 달성 여부 확인
        public void CheckAchievement(long currentSales)
        {
            IsAchieved = (currentSales >= TargetSales);
        }
    }
}
