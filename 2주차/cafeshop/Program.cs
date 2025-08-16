namespace cafeshop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //플레이어가 처음에 자본금을 가지고 게임을 시작합니다. 이 플레이어는 카페를 운영하고 싶어 합니다.
            //플레이어는 아이템을 특정한 소비자에게 판매할 수 있습니다.
            //소비자는 아이템의 선호도가 존재해서, 소비자만 판매 할수 있는 금액이 다릅니다.
            //(정보) 위의 내용으로 게임을 만든다고 가정했을 때 이 게임에 필요한 클래스를 아래와 같이 정의해 보세요.
            //플레이어(자본금, 인지도)
            //매장(규모, 이벤트)
            //고객(등급, 소지금)
            //아이템(가격, 상품명) 
            //목표(기간, 매출액, 달성여부)

            // GameManager 인스턴스 생성 및 게임 시작
            bool playAgain = true;

            while (playAgain)
            {
                // GameManager 인스턴스 생성
                GameManager gameManager = new GameManager(
                    initialCapital: 50000,
                    initialRecognition: 10,
                    storeSize: 10,
                    storeEvent: "오픈 기념 10% 할인",
                    goalDuration: 7,
                    targetSales: 100000);

                // 게임 시작
                gameManager.StartGame();

                Console.WriteLine("\n게임을 다시 시작하시겠습니까? (Y/N)");
                string restartInput = Console.ReadLine();

                if (restartInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    // 화면 지우기
                    Console.Clear();
                    Console.WriteLine("게임을 다시 시작합니다!");
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("\n게임을 종료합니다. 이용해주셔서 감사합니다!");
                }
            }
        }
    }
}
