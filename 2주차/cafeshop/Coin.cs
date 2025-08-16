using System;

public class Coin
{

    /*
	 * (1) Coin 클래스, 코인 증가하는 량, 코인의 크기 사이즈, 코인 색깔 (string) 변수와 함수
     * (2) Item 클래스, 이름, 가격, 아이템 타입
     * (3)player 클래스 이동 속도, 점프, 힘의 크기 ... -> 함수(move),(jump)
     * 
     * 멤버변수를 이용해서 함수의 이름이 Move인 함수를 만들어줘.
	 * 
	 *  // 멤버 변수
        public string name;
        public int Publishday;

        public info(string name, int Publishday)
        {
            this.name = name;
            this.Publishday = Publishday;
        }
	 * 
	 * 
	 */

    public int plus;
    public int size;
    public string color;

    public Coin(int plus, int size, string color)
    {
        this.plus = plus;
        this.size = size;
        this.color = color;
    }


}
