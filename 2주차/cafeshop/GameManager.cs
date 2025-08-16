using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeshop
{
    public class GameManager
    {
        private Player _player;
        private Store _store;
        private Goal _goal;
        private List<Item> _availableItems;
        private List<Coin> _foundCoins;
        private int _customerCount; // 고객 수를 추적하는 필드 추가

        public GameManager(int initialCapital, int initialRecognition, int storeSize, string storeEvent, int goalDuration, long targetSales)
        {
            _player = new Player(initialCapital, initialRecognition);
            _store = new Store(storeSize, storeEvent);
            _goal = new Goal(goalDuration, targetSales);

            _availableItems = new List<Item>
        {
            new Item("아메리카노", 4000),
            new Item("카페라떼", 5000),
            new Item("딸기 케이크", 7000)
        };

            _foundCoins = new List<Coin>();
            _customerCount = 0; // 고객 수 초기화
        }

        public void StartGame()
        {
            Console.WriteLine("카페 운영 게임을 시작합니다!\n");

            Console.WriteLine("--- 아이템 구매 단계 ---");
            BuyItemsForPlayer();
            Console.WriteLine();

            SimulateFindingCoin();

            bool goalAchieved = false;
            while (!goalAchieved)
            {
                Console.WriteLine("--- 고객 판매 단계 ---");
                SimulateCustomerSale();

                _goal.CheckAchievement(_store.TotalSales);
                goalAchieved = _goal.IsAchieved;

                if (goalAchieved)
                {
                    Console.WriteLine("축하합니다! 매출 목표를 달성했습니다! 🎉");
                }
                else
                {
                    DisplayCurrentStatus();
                    
                    Console.WriteLine("계속해서 게임을 진행하시겠습니까? (Y/N)");
                  
                    string continueInput = Console.ReadLine();
                    if (!continueInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("\n게임을 종료합니다.");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine(); // 한 줄 띄우기
                }
            }
        }

        private void BuyItemsForPlayer()
        {
            _player.BuyItem(_availableItems[0]);
            _player.BuyItem(_availableItems[2]);
        }

        private void SimulateCustomerSale()
        {
            // 간단한 시뮬레이션을 위해 한 번에 한 명의 고객만 판매
            Customer customer = new Customer(3, 10000);
            customer.SetPreference("아메리카노", 50);

            if (customer.CanAfford(_availableItems[0].Price))
            {
                int finalPrice = _availableItems[0].Price + customer.Preferences["아메리카노"];
                _store.AddSales(finalPrice);
                _player.Capital += finalPrice;
                _customerCount++; // 고객 수 증가

                Console.WriteLine($"고객이 {_availableItems[0].Name}을(를) {finalPrice}원에 구매했습니다.");
            }
            else
            {
                Console.WriteLine("고객이 아이템을 구매할 수 없습니다.");
            }
        }

        private void DisplayCurrentStatus()
        {
            Console.WriteLine("\n--- 현재 상황 ---");
            Console.WriteLine($"🛒 현재까지 고객 수: {_customerCount}명");
            Console.WriteLine($"💰 현재까지 총 매출액: {_store.TotalSales}원");

            long remainingSales = _goal.TargetSales - _store.TotalSales;
            Console.WriteLine($"🎯 목표까지 남은 금액: {remainingSales}원\n");
        }

        private void SimulateFindingCoin()
        {
            Console.WriteLine("--- 특별 이벤트: 동전 발견! ---");
            Coin foundCoin = new Coin(1000, 3, "gold");
            _foundCoins.Add(foundCoin);
            _player.Capital += foundCoin.plus;
            Console.WriteLine($"🎉 {foundCoin.color}색 동전을 발견했습니다! 가치: {foundCoin.plus}원");
            Console.WriteLine($"현재 자본금: {_player.Capital}\n");
        }
    }
}
