using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 target = new Vector3 (8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //1. MoveTowards: 보다 감속시간이 김(현재위치, 목표위치, 속도)
        /*transform.position = 
            Vector3.MoveTowards(transform.position
                                , target, 0.1f);*/

        //2. SmoothDamp: 미끄러지듯이 감속 이동 (현재위치, 목표위치, 참조속도, 속도(반비례))
        /*Vector3 velo = Vector3.zero; //.up *50(50만큼 위로 올라감)

        transform.position =
            Vector3.SmoothDamp(transform.position, target, 
                                ref velo, 0.1f); //ref: 참조 접근*/

        //3. Lerp: 선형 보간, 마지막 매개변수에 비례하여 속도 증가 (현재위치, 목표위치, 속도(max=1))
        /*transform.position =
            Vector3.Lerp(transform.position, target, 1f);*/

        //4. Slerp: 구면 선형 보간
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }
}
