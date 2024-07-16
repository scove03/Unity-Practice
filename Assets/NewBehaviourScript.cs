using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //1. 변수
    int level = 5;
    float strength = 15.5f;
    string title = "전설의";
    string playerName = "나검사";
    bool isFullLevel = false;
    int exp = 1500;
    int health = 30;
    int mana = 25;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        /*Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);*/

        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        /*Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);*/

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        /*Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        Debug.Log("가지고 있는 아이템");
        items.RemoveAt(0);
        Debug.Log(items[1]);*/

        //3.연산자
        exp = exp + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        /*Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);*/

        int nextExp = 300 - (exp % 300);
        /*Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);*/

        
        /*Debug.Log("용사의 이름은?");
        Debug.Log(title+ " " + playerName);*/

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        //Debug.Log("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        //Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        bool isBadConditon = health <= 50 || mana <= 20;
        //Debug.Log("용사의 상태가 나쁩니까? " + isBadConditon);

        string conditon = isBadConditon ? "나쁨" : "좋음";
        //Debug.Log("용사의 상태가 나쁩니까? " + conditon);

        
        //4.키워드 (int float string bool new List)


        //5.조건문
        /*if (conditon == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if (isBadConditon && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadConditon && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션 30을 사용하였습니다.");
        }*/

        string monsterAlarm;

        /*switch (monsters[0]) {
            case "슬라임": case "사막뱀": Debug.Log("소형 몬스터가 출현!");  break;
            case "악마":  Debug.Log("중형 몬스터가 출현!");   break;
            case "골렘":  Debug.Log("대형 몬스터가 출현!");   break;
            default:    Debug.Log("??? 몬스터가 출현!");  break;
        }*/

        //6. 반복문
        /*while (health > 0) {
            health--;
            if (health > 0) {
                Debug.Log("독 데미지를 입었습니다. " + health);
            }
            else
                Debug.Log("사망하였습니다.");

            if (health == 10) {
                Debug.Log("해독제를 사용합니다."); break;
            }
        }
        
        for (int count=0; count<10; count++) {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }

        for (int index=0; index<monsters.Length; index++) {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        foreach (string monster in monsters) {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }*/


        //7. 함수
        Heal();

        /*for (int index=0; index < monsters.Length; index++) {
            Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
        }*/

        //8. 클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + " 입니다.");
        Debug.Log(player.move());
    }

    //7.함수 (메소드)
    void Heal() {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }

    string Battle(int monsterLevel) 
    {
        string result;
        if (level >= monsterLevel) result = "이겼습니다.";
        else result = "졌습니다.";
        return result;
    }
}