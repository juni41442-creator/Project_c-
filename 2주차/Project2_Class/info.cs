using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Class
{
    /*
     * 지난주 복습, 변수 - 함수
     * 변수 : 컴퓨터에게 어떠한 타입으로 데이터를 저장할지 기억하게 하는 방법, int,float,string, char + 이름
     * 함수 : 반복적으로 사용되는 코드 뭉치를 하나의 이름으로 사용할 수 있도록 하는 방법
     * plus(int a, int b)
     * 처음 부터 다시 만들까요? 이미 있는 내용에서 추가, 코드 뭉치를 만들었다고 가정하자.
     * 4곳, 5줄짜리 코드를 복사 붙여넣기로 구현을 했습니다. 5번 연속으로 수정을 해야 합니다.
     * 5개 중복된 코드를 하나의 코드로 만드는 것. 반복을 어떻게 없앨것인가?
     *  
     */

    /*
     * 클래스는 무엇인가? 변수와 변수를 사용하는 함수로 붂여진 데이터다.
     * 
     * 클래스 문법
     * (1) 멤버 변수, 멤버 함수(메소드 method) 이루어져 있다. - 변수와 함수를 선언해야 한다.
     * 
     * (2) 멤버 변수를 선언을 할 떄 (접근 지정자) +(변수타입) + (변수 이름)
     * 
     * 접근 지정자는 무엇인가요? 어떻게 접근을 하 수 있는가?
     *  - 공유 가능 public
     *  - 외부에서 사용불가 private
     *  - 외부로 부터 사용을 보호, 자식은 허용 protected
     *  
     *  (3) 문법이 어렵다? 접근 지정자를 전부다 public 선언을 해도 코든는 작성할 수 있습니다.
     *  
     *  (4) 코드를 작성 권장사항에서는 최대한 public을 사용하지 마세요. 스파게티 코드.
     *  
     *  (5) 생성자. 변수 . 데이터를 저장하는 비어있는 공간
     *  
     *  
     *  
     */

    //정보를 추상적으로 표현한 데이터다. -> class 이름 , (변수,함수) 스코프 연산자 { }


    /*
     * 아무클래스를 직접 만들어 봅시다.
     * AI의 힘을 빌리지 않고 만듭니다.
     * 
     * (1) Coin 클래스, 코인 증가하는 량, 코인의 크기 사이즈, 코인 색깔 (string) 변수와 함수
     * (2) Item 클래스, 이름, 가격, 아이템 타입
     * (3)player 클래스 이동 속도, 점프, 힘의 크기 ... -> 함수(move),(jump)
     * 
     * 멤버변수를 이용해서 함수의 이름이 Move인 함수를 만들어줘.
     * 
     * 
     * 게임 제목 :
     * 
     * 게임에 사용되느 클래스 : 모든 클래스는 동등하다.
     * 클래스를 정리해 보세요.
     * -AI 전달, Contents (검증,에러,...)-> 재생성 재생성..
     * 
     * -0 바로 만들어줘.
     * -1 클래스를 직접 만들어서 내용을 바탕으로 코드를 만들어줘.
     * -2 분석 비슷하게 따라 만들어 보기.
     * -3. 아주 작은 단위의 미니 게임을 많이 만들어 보기.
     * - 미니 게임 천국, 작은 게임 많이 만들어서 작은 게임들을 합치면 더 커진 게임.
     * - 어몽어스(마피아) - 미니 게임 미션
     * 
     * 
     * 
     * 
     * 클래스의 관계를 설계
     * 
     * 농사. 작물(고구마, 호박, 감자)- 상속
     * 작물을 사용하는 클래스 handler,manger 농부
     * 
     * 
     */
    class info
    {
        // 멤버 변수
        public string name;
        public int Publishday;

        public info(string name, int Publishday)
        {
            this.name = name;
            this.Publishday = Publishday;
        }

        public void SetName(string _name)
        {
            name = _name;
        }
       
    }
}
