using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnime : MonoBehaviour
{
    public string upAnime = "";
    public string downAnime = "";
    public string rightAnime = "";
    public string leftAnime = "";
    public string idleAnime = "";

    string nowMode = "";

    bool pushFlag = false; // 스페이스 키가 눌린 상태인지 
    bool jumpFlag = false; // 점프 상태인지 
    bool groundFlag = false; // 발이 무언가에 닿았는지 


    // Start is called before the first frame update
    void Start()
    {
        nowMode = idleAnime; // 시작 시 애니메이션
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && groundFlag)
        {
            if (pushFlag == false)// 계속 누르고 나가지 않으면
            {
                jumpFlag = true; // 점프 준비 
                pushFlag = true; // 계속 누른 상태 
            }
        }
        else
        {
            pushFlag = false; // 계속 누른 상태 해제 
        }

        if (groundFlag == false)
        {
            nowMode = upAnime;
        }
        else
        {
            if (Input.GetKey("down"))
            {
                nowMode = downAnime;
            }
            if (Input.GetKey("right"))
            {
                nowMode = rightAnime;
            }
            if (Input.GetKey("left"))
            {
                nowMode = leftAnime;
            }
            if (Input.GetKeyUp("down"))
            {
                nowMode = idleAnime;
            }
            if (Input.GetKeyUp("right"))
            {
                nowMode = idleAnime;
            }
            if (Input.GetKeyUp("left"))
            {
                nowMode = idleAnime;
            }
        }
    }

    private void FixedUpdate()
    {

        if (jumpFlag)
        {
            jumpFlag = false;
        }

        this.GetComponent<Animator>().Play(nowMode);
    }

    void OnTriggerStay2D(Collider2D collision)
    { // 발이 무언가에 닿으면 
        groundFlag = true;
        nowMode = idleAnime;
    }
    void OnTriggerExit2D(Collider2D collision)
    { // 발에 아무 것도 닿지 않으면 
        groundFlag = false;
    }
}
