using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Orc orc = new Orc();
        orc.idle();
        orc.move();
    }

    public class Monster 
    {
        public void idle() 
        {
            Debug.Log("idle");
        }
        public void move() 
        {
            Debug.Log("move");
        }
    }

    public class Orc : Monster 
    {
        public void idle() 
        {
            base.idle(); //base: 부모클래스 함수 접근
        }
        public void move() 
        {
            base.move();
        }
    }
}
