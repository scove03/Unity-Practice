using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    void Update()
    {
        //Input: 게임 내 입력을 관리하는 클래스
        //anyKey: 아무 입력을 받을 때
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //입력을 누르고 있을 때
        /*if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");*/

        //========================================

        //GetKey: 키보드 버튼 입력을 받으면 true
        /*if (Input.GetKeyDown(KeyCode.Return)) //Return: 엔터키, Escpae: esc
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow)) //Arrow: 방향키
            Debug.Log("왼쪽으로 이동 중");
        
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");*/

        //=======================================

        //마우스 입력을 받으면 true
        /*if (Input.GetMouseButtonDown(0)) //0: 왼쪽 마우스 버튼, 1: 오른쪽 마우스 버튼
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");*/

        //==========================================

        /*if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는중");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");*/

        if (Input.GetButton("Horizontal"))
            //GetAxis: 수평 수직 버튼 입력을 받으면 float(가속도o)
            //GetAxisRaw: (가속도 x)
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        
        if (Input.GetButton("Vertical"))
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Vertical"));

    }
}
