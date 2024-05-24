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

    bool pushFlag = false; // �����̽� Ű�� ���� �������� 
    bool jumpFlag = false; // ���� �������� 
    bool groundFlag = false; // ���� ���𰡿� ��Ҵ��� 


    // Start is called before the first frame update
    void Start()
    {
        nowMode = idleAnime; // ���� �� �ִϸ��̼�
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && groundFlag)
        {
            if (pushFlag == false)// ��� ������ ������ ������
            {
                jumpFlag = true; // ���� �غ� 
                pushFlag = true; // ��� ���� ���� 
            }
        }
        else
        {
            pushFlag = false; // ��� ���� ���� ���� 
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
    { // ���� ���𰡿� ������ 
        groundFlag = true;
        nowMode = idleAnime;
    }
    void OnTriggerExit2D(Collider2D collision)
    { // �߿� �ƹ� �͵� ���� ������ 
        groundFlag = false;
    }
}
