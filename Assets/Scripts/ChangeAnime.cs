using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnime : MonoBehaviour
{
    public string upAnime = "";
    public string downAnime = "";
    public string rightAnime = "";
    public string leftAnime = "";

    string nowMode = "";

    bool pushFlag = false; // �����̽� Ű�� ���� �������� 
    bool jumpFlag = false; // ���� �������� 
    bool groundFlag = false; // ���� ���𰡿� ��Ҵ��� 
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        nowMode = downAnime;
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space") && groundFlag)
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

        if (Input.GetKey("space") && jumpFlag == false)
        {
            nowMode = upAnime;
        }
        if (Input.GetKey("down") && jumpFlag == true)
        {
            nowMode = downAnime;
        }
        if (Input.GetKey("right") && jumpFlag == true)
        {
            nowMode = rightAnime;
        }
        if (Input.GetKey("left") && jumpFlag == true)
        {
            nowMode = leftAnime;
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
    }
    void OnTriggerExit2D(Collider2D collision)
    { // �߿� �ƹ� �͵� ���� ������ 
        groundFlag = false;
    }
}
