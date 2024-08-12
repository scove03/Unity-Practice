using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//상속: 부모 클래스를 토대로 자식 클래스를 만드는 것
//protected: 클래스 내부와 상속 클래스에서만 멤버에 접근 가능
public class Class3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Orc3 orc = new Orc3();
        Player3 player = new Player3();

        Debug.Log("플레이어 HP: " + player.hp + "플레이어 공격력: " + player.damage);
        Debug.Log("오크 HP: " + orc.hp + "오크 공격력: " + orc.damage);
        Debug.Log("플레이어가 오크를 공격합니다.");
        int orcHP = player.Attack(orc.hp);
        Debug.Log("오크의 남은 HP: " + orcHP);
        Debug.Log("오크가 플레이어를 공격합니다.");
        int playerHP = orc.Attack(player.hp);
        Debug.Log("플레이어의 남은 HP: " + playerHP);
        Debug.Log("********전투 종료********");
    }
}

class Monster 
{
    public int hp = 20;
    public int damage = 5;

    public void Shout() {
        Debug.Log("소리친다");
    }
} 

class Orc3 : Monster {
    public int Attack(int playerHP) {
        playerHP -= damage;
        return playerHP;
    }

    public void OrcShout() {
        base.Shout();
    }
}

class Player3 {
    public int hp = 30;
    public int damage = 10;

    public int Attack(int OrcHP) { 
        OrcHP-= damage;
        return OrcHP;
    }
}