namespace Project2_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 게임을 AI 로 만들기 (복습)
            //아누 AI 사이트에 들어가서 만들고 싶은 게임을 검색하는 방법
            //C#으로 만들어라. 구체적인 정보를 전달해야 AI 원하는 결과물을 도출 할 수 있다.
            //테트리스 게임, 블록4개,.. 조건 만들어줘. +함수, 변수

            //게임을 만들어 달라고 질문햇을때의 단점.
            // - 여러분이 게임에 추가하고 싶은 컨텐츠를 스스로 추가하기가 어렵다.
            //남이 만들어 놓은 규칙에서 추가해야 되기 때문에 (작성된 코드를 이해를 하지 못한 경우)
            //프로그래밍 언어 문법이 존재하는데 , 이 문법을 이해 하지 못하고 사용하면 에러가 발생한다.(네이밍 문제)

            // 2. 게임의 구성요소를 AI에게 작성해달라고 요청해 보기.
            //게임을 작은 구성 요소를 나누어야 할 필요성을 느끼셨다면..
            //어떻게 나눌 것인가? -> Class 객체지향 프로그래밍
            //class를 생성하는 것. 클래스의 관계를 설계하는 것.
            //객체들 :플레이어 (player) , 목적, 방해 요소(enemy,trap, environment)

            //플레이어가 처음에 소지금을 가지고 게임을 시작합니다. 이 플레이어는 특정 기간마다 빚을 변제해야 합니다.
            //플레이어는 아이템을 특정한 소비자에게 판매할 수 있습니다. 소비자는 아이템의 선호도가 존재해서, 소비자만 판매 할수 잇는 
            //금액이 다릅니다.(정보) 위의 내용으로 게임을 만든다고 가정햇을때 . 이게임에 필요한 클래스를 아래에 정의해 보세요.
            //객체 : 플레이어(소지금, 남은 빛 변제 기간, 만난 고객 정보)
            //빚, (수치, 이벤트)
            //고객,( 등급, 소지금)
            //아이템(고객마다 원하는 종류가 다양하다) 

            //3. 게임에 등장할 요소(클래스) 어느 정도 구현 하였으면, 게임에 등장 시켜야 합니다.
            // 어디에 그 코드를 작성하는가? main함수에서 코드가 실행된다. 만들어 놓은  클래스를 이 함수에서 다시 호출한다.
            // 4가지 클래스를 사용해서 게임을 main함수에 플레이가 되도록 만들어줘.

            Console.WriteLine("=== 게임 시작 ===");

            // 1. 플레이어, 빚, 고객, 아이템 객체 생성
            Player player = new Player(initialMoney: 5000, debtDueDate: 7);
            Debt debt = new Debt(amount: 15000, dueDate: 7);

            Customer customer1 = new Customer(grade: "VIP", initialMoney: 20000, preferredItemType: "장비");
            Customer customer2 = new Customer(grade: "Normal", initialMoney: 5000, preferredItemType: "보석");
            player.MetCustomers.Add(1, customer1);
            player.MetCustomers.Add(2, customer2);

            Item item1 = new Item(name: "마법 검", itemType: "장비", basePrice: 5000);
            Item item2 = new Item(name: "황금 반지", itemType: "보석", basePrice: 8000);
            Item item3 = new Item(name: "낡은 지도", itemType: "잡화", basePrice: 1000);

            // 2. 플레이어에게 아이템 추가
            player.AddItem(item1);
            player.AddItem(item2);
            player.AddItem(item3);

            Console.WriteLine("\n--- 빚을 갚기 위한 아이템 판매 ---");

            // 3. 아이템 판매 시도 (VIP 고객에게 장비 판매)
            Console.WriteLine($"\n[1] VIP 고객에게 '{item1.Name}' 판매 시도");
            player.SellItem(item1.Name, 1);

            // 4. 아이템 판매 시도 (일반 고객에게 보석 판매)
            Console.WriteLine($"\n[2] 일반 고객에게 '{item2.Name}' 판매 시도");
            player.SellItem(item2.Name, 2);

            // 5. 빚 변제 시도
            Console.WriteLine("\n--- 빚 변제 시도 ---");
            if (player.Money >= debt.Amount)
            {
                Console.WriteLine($"✅ 현재 소지금 {player.Money}원으로 빚 {debt.Amount}원을 변제합니다.");
                player.Money -= debt.Amount;
                Console.WriteLine($"남은 소지금: {player.Money}");
            }
            else
            {
                Console.WriteLine($"❗ 소지금이 부족합니다. 빚 {debt.Amount}원을 갚을 수 없습니다.");
                Console.WriteLine("...게임 오버...");
            }

            Console.WriteLine("\n=== 게임 종료 ===");
        }
    }

}


