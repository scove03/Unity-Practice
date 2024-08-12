using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Orc2 orc1 = new Orc2();
        Orc2 orc2 = new Orc2();

        orc1.damage = 5;
        orc2.damage = 10;

        orc1= orc2;//orc1의 주소를 orc2로 변경

        orc1.defence = 20;
        //클래스는 참조타입
        //orc1의 값을 변경해도 주소가 or2 이므로
        //변경이안됨 orc1이 orc2가 된것

        Debug.Log("오크1 공격력: " + orc1.damage);
        Debug.Log("오크1 방어력: " + orc1.defence);
        Debug.Log("오크2 공격력: " + orc2.damage);
        Debug.Log("오크2 방어력: " + orc2.defence);
    }
}

class Orc2 
{ 
    //클래스 멤버: 클래스의 속한 변수, 함수
    //클래스 필드: 클래스의 속한 변수
    //접근 제한자
    //public: 클래스 외부에서 멤버에 접근 가능
    //private: 클래스 내부에서만 멤버에 접근 가능
    //protected: 클래스 내부와 상속 클래스에서만 멤버에 접근 가능
    public int damage;
    public int defence =10;
    void attack() 
    {
        //공격한다.
    }
}
