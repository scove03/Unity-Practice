using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    MeshRenderer mesh;
    Material material;
    // Start is called before the first frame update
    void Start() {
        mesh = GetComponent<MeshRenderer>();
        material = mesh.material;
    }

    //CollisionEnter: 물리적 충돌이 시작할 때 호출함수
    //Stay: 충돌 중, Exit: 충돌 종료
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "MyBall")
            material.color = new Color(0, 0, 0);//Color32: 255개 색상
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name == "MyBall")
            material.color = new Color(1, 1, 1);//Color32: 255개 색상
    }
}
