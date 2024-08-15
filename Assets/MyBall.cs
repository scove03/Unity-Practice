using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //1. 속력 바꾸기
        //rigid.velocity = Vector3.right; //속도(이동)
        //rigid.velocity = new Vector3(2, 4, 3);
    }

    // Update is called once per frame
    void FixedUpdate() //rigidbody는 FixedUpdate에 작성
    {
        //2. 힘 가하기
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);//ForceMode: 힘을 주는 방식(가속, 무게 반영)
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);//AddForce: 힘을 가한다
        }

        Vector3 vector = new Vector3(
            Input.GetAxisRaw("Horizontal"), 
            0,Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vector, ForceMode.Impulse);

        //3. 회전력
        //rigid.AddTorque(Vector3.up); //AddTorque: 벡터 방향을 축으로 회전력 생김
    }

    //Trigger: 물체가 겹쳤는지(물리적 충돌 X)
    private void OnTriggerStay(Collider other) {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}
