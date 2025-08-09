namespace Project_1_GameFlow
{

    using System;

    //public void Method()
    //{
    //    int playerHP = 100;
    //    string playerName = "영웅";
    //    Console.WriteLine(playerHP);
    //    Console.WriteLine(playerName);
    //}

    internal class Program
    {
        
            #region 프로그래민 언어의 기본 문법 - 변수



            // 변수 : 특정 타입의 데이터를 메모리에 저장해서 다시 사용하는 데이터.
            // 정수, 실수(부동소수점), 문자
            // 타입뒤에 변수를 구분하기 위한 이름을 지어준다.

            //내가 정수를 사용하고 싶다. int
            //내가 실수를 사용하고 싶다. float
            //내가 문자열을 사용하고 싶다. string
            //내가 문자를 사용하고 싶다. char

            //정수의 이름 : playerHP
            //실수의 이름 :시간을 초단위로 표현 Time
            //문자열의 이름 : content
            //문자의 이름 : myChar

            //변수의 선언 및 초기화

            //(1)AI 만들어준 데이터를 다른 데이터로 바꾸어 보세요.
            //(2) AI 질문을 할 때 변수의 이름과 타입을 지정해서 질문하세요.
            //ex) 플레이어의 체력과 공격력의변수의 이름은 playerHP, playerATK 타입 int, float, string, char

            //int num1 = 10;
            //float numfloat1 = 1.1f;
            //string myStrinfg = "안녕";
            //char myChar = 'A';

            //int playerHP = 50;
            //float Time = 30.5f;
            //string title = "테트리스";
            //char myChar2 = 'B';





            #endregion

            #region 프로그래밍 언어의 기본 문법 - 메소드(함수)

            // 기본 형태 
            // 접근 지정자 리턴타입 함수 이름(타입 변수 이름)
            // plblic void MethodName(int num)

            //C#에서의 특징
            //1. 메소드는 클래스 안에서 저의 되어야 한다.
            //2. 메소드는 선언과 사용방식이 다르다.
            //2-1 선언은 구현되지 않은 내용을 직접 정의하는 것이다. 범위로 표현을 해준다.
            //함수 선언이후 중괄호로 내용을 표시한다.
            //2-2 정의된 함수를 사용하기 위해서는 함수의 이름과 소괄호를 함께 호출한다.

            //함수를 만들어줘. 접근 지정자를 public, 변환타입을 void로 함수 이름을 showtitle 만들어줘. 매개 인자를 누락

            //콘솔환경, 언어는 c# 특정문자열의 색상을 다른 색상으로 변견해주는 함수를 만들어줘.
            //접근 지정자는 public, 반환값은 너가 정해줘, 함수의 이름 setTextColor로, 매개 변수를 색상의 이름으로 받을 수 있도록 타입을 string 변수 이름 color로 만들어줘.

            #endregion


            #region 게임 개발 영역
            // 주석 : 컴퓨터가 읽지 못하는 영역입니다.
            // 내용을 정리하거나 코드를 읽는 다른 사람을 배려해서 작성하는 영역입니다.
            //단축키 
            //ctrl + K + C 범위 주석 활성화
            //ctrl + K + u 범위 주석 비활성화
            //shift + 키보드 방향이 위, 아래

            #region 1. 타이틀
            //1.타이틀
            //"C#으로 작성을 할 것이다.콘솔 환경에서 타이틀을 만들어줘.            
            #endregion

            #region 2. 캐릭터

            //2.캐릭터

            //캐릭터는 체력, 공격력이 존재한다.
            //캐릭터는 체력, 공격력, 방어력이 존재한다.
            //캐릭터는 체력, 공격력, 방어력, 이동 속도가 존재한다. UI
            //게임 캐릭터의 체력과 공격력을 설정한 후 콘솔 환경에서 UI로 화면에 떠오르게 해줘.

            // 텍스트 색상 변경을 위한 클래스
    public class ConsoleColorChanger
        {
            public static void SetTextColor(string color)
            {
                switch (color.ToLower())
                {
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "magenta":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "gray":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        class MountainGame
        {
            static void Main(string[] args)
            {
                // 1. 게임 타이틀 화면
                DisplayTitleScreen();

                // 2. 캐릭터 정보 설정
                string playerName = "용감한 모험가";
                int playerHealth = 100;
                int playerAttackPower = 70;
                int playerBP = 50;

                // 3. 캐릭터 UI 화면에 띄우기
                Console.Clear();

                // ✅ 게임 시작 메시지를 초록색으로 출력
                ConsoleColorChanger.SetTextColor("green");
                Console.WriteLine("게임을 시작합니다!\n");
                ConsoleColorChanger.SetTextColor("white"); // 기본색상으로 복원

                DrawCharacterUI(playerName, playerHealth, playerAttackPower, playerBP, 5, 5);

                Console.SetCursorPosition(0, 15);
                Console.WriteLine("\n[게임 진행...]");

                // ✅ 몬스터 정보 개별 변수로 설정
                string monsterName = "고블린";
                int monsterHealth = 60;
                int monsterAttackPower = 25;

                // 4. 게임 시작 및 UI 출력
                Console.Clear();

                ConsoleColorChanger.SetTextColor("green");
                Console.WriteLine("게임을 시작합니다! 전투를 시작합니다!\n");
                ConsoleColorChanger.SetTextColor("white");

                // ✅ 몬스터 정보 출력 함수 호출
                DisplayMonsterInfo(monsterName, monsterHealth, monsterAttackPower,40,5);

                Console.SetCursorPosition(0, 15);
                Console.WriteLine("\n[전투 진행...]");

                // ✅ 전투 시작! 몬스터 체력이 0보다 크면 전투 계속
                while (monsterHealth > 0 && playerHealth > 0)
                {
                    // 모험가가 고블린 공격
                    Console.WriteLine($"\n> {playerName}의 공격! {monsterName}에게 {playerAttackPower}의 피해를 입혔습니다.");
                    monsterHealth -= playerAttackPower;
                    DrawCharacterUI(playerName, playerHealth, playerAttackPower, playerBP, 5, 5); // 플레이어 정보는 변경 없으니 그대로 표시
                    DisplayMonsterInfo(monsterName, monsterHealth, monsterAttackPower, 40, 5); // 몬스터 체력 업데이트

                    // 고블린이 쓰러졌는지 확인
                    if (monsterHealth <= 0)
                    {
                        Console.WriteLine($"\n> {monsterName}이(가) 쓰러졌습니다!");
                        break; // 반복문 탈출
                    }

                    // 고블린이 모험가 공격
                    Console.WriteLine($"\n> {monsterName}의 공격! {playerName}에게 {monsterAttackPower}의 피해를 입혔습니다.");
                    playerHealth -= (monsterAttackPower - playerBP); // 방어력만큼 피해 감소
                    DrawCharacterUI(playerName, playerHealth, playerAttackPower, playerBP, 5, 5); // 플레이어 체력 업데이트
                    DisplayMonsterInfo(monsterName, monsterHealth, monsterAttackPower, 40, 5); // 몬스터 정보는 변경 없으니 그대로 표시

                    // 모험가가 쓰러졌는지 확인
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine($"\n> {playerName}이(가) 쓰러졌습니다... 게임 오버!");
                        break; // 반복문 탈출
                    }
                }

                // ✅ 전투 결과 메시지 출력
                if (playerHealth > 0)
                {
                    ConsoleColorChanger.SetTextColor("yellow");
                    Console.WriteLine("\n🎉 전투 승리! 🎉");
                    ConsoleColorChanger.SetTextColor("white");
                }
                else
                {
                    ConsoleColorChanger.SetTextColor("red");
                    Console.WriteLine("\n💀 전투 패배... 💀");
                    ConsoleColorChanger.SetTextColor("white");
                }




                // ✅ 게임 종료 메시지를 빨간색으로 출력
                ConsoleColorChanger.SetTextColor("red");
                Console.WriteLine("\n아무 키나 눌러 게임을 종료합니다.");
                ConsoleColorChanger.SetTextColor("white"); // 기본색상으로 복원

                Console.ReadKey();
            }

            static void DisplayTitleScreen()
            {
                string mountainArt = @"
            /\
           /  \
      /\  /    \      /\
     /  \/      \    /  \
_  _/__\__  _  _/__\__  _
/ \ /    \  / \ /    \  /
/   \\    / /   \\    / /
/    \/__/ /    \/__/

=====================================
|       나의 멋진 산악 게임         |
=====================================
          Press 'S' to Start
          Press 'Q' to Quit
";
                Console.Clear();

                // ✅ 타이틀 메시지를 노란색으로 출력
                ConsoleColorChanger.SetTextColor("yellow");
                Console.WriteLine(mountainArt);
                ConsoleColorChanger.SetTextColor("white"); // 기본색상으로 복원

                while (true)
                {
                    Console.Write("\n입력: ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    char key = keyInfo.KeyChar;

                    if (key == 's' || key == 'S')
                    {
                        break;
                    }
                    else if (key == 'q' || key == 'Q')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        // ✅ 잘못된 키 입력 시 빨간색 경고 메시지 출력
                        ConsoleColorChanger.SetTextColor("red");
                        Console.WriteLine("\n잘못된 키입니다. 다시 시도하세요.");
                        ConsoleColorChanger.SetTextColor("white"); // 기본색상으로 복원
                    }
                }
            }

            static void DrawCharacterUI(string name, int health, int attackPower, int bp, int x, int y)
            {
                string border = "--------------------------";

                Console.SetCursorPosition(x, y);
                Console.WriteLine("+" + border + "+");

                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine($"| 이름: {name,-15} |");

                Console.SetCursorPosition(x, y + 2);
                // ✅ 체력이 50 이하일 때 빨간색으로 표시
                if (health <= 50)
                {
                    Console.SetCursorPosition(x, y + 2);
                    ConsoleColorChanger.SetTextColor("red");
                    Console.WriteLine($"| 체력: {health,-15} |");
                    ConsoleColorChanger.SetTextColor("white");
                }
                else
                {
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine($"| 체력: {health,-15} |");
                }

                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine($"| 공격력: {attackPower,-13} |");

                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine($"| 방어력: {bp,-13} |");

                Console.SetCursorPosition(x, y + 5);
                Console.WriteLine("+" + border + "+");
            }

            // ✅ 몬스터 정보를 출력하는 메서드 추가
            static void DisplayMonsterInfo(string name, int health, int attackPower, int x, int y)
            {
                string border = "--------------------------";

                Console.SetCursorPosition(x, y);
                Console.WriteLine("+" + border + "+");

                Console.SetCursorPosition(x, y + 1);
                ConsoleColorChanger.SetTextColor("yellow"); // 몬스터 정보를 노란색으로 강조
                Console.WriteLine($"| 이름: {name,-15} |");
                ConsoleColorChanger.SetTextColor("white"); // 기본색상으로 복원

                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine($"| 체력: {health,-15} |");

                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine($"| 공격력: {attackPower,-13} |");

                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("+" + border + "+");
            }
        }
            #endregion
        

    }
}
#endregion