using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearGame2 : MonoBehaviour
{
    public string firstTargetName;
    public string secondTargetName;
    public string thirdTargetName;
    public string fourthTargetName;
    public string fifthTargetName;

    public string firstHideName;
    public string secondHideName;
    public string thirdHideName;
    public string fourthHideName;
    public string fifthHideName;

    public string sceneName;  // �� �̸� : Inspector�� ����


    private bool findFirstTarget = false;
    private bool findSecondTarget = false;
    private bool findThirdTarget = false;
    private bool findFourthTarget = false;
    private bool findFifthTarget = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)// �浹���� ��
    {
        // ���� �浹�� ���� �̸��� ��ǥ ������Ʈ���ٸ�
        if (collision.gameObject.name == firstTargetName)
        {
            findFirstTarget = true;
            GameObject hideObjectft = GameObject.Find(firstTargetName);
            hideObjectft.SetActive(false);
            GameObject hideObjectfh = GameObject.Find(firstHideName);
            hideObjectfh.SetActive(false);
        }
        if (collision.gameObject.name == secondTargetName)
        {
            findSecondTarget = true;
            GameObject hideObjectst = GameObject.Find(secondTargetName);
            hideObjectst.SetActive(false);
            GameObject hideObjectsh = GameObject.Find(secondHideName);
            hideObjectsh.SetActive(false);
        }
        if (collision.gameObject.name == thirdTargetName)
        {
            findThirdTarget = true;
            GameObject hideObjecttt = GameObject.Find(thirdTargetName);
            hideObjecttt.SetActive(false);
            GameObject hideObjectth = GameObject.Find(thirdHideName);
            hideObjectth.SetActive(false);
        }
        if (collision.gameObject.name == fourthTargetName)
        {
            findFourthTarget = true;
            GameObject hideObjectfot = GameObject.Find(fourthTargetName);
            hideObjectfot.SetActive(false);
            GameObject hideObjectfoh = GameObject.Find(fourthHideName);
            hideObjectfoh.SetActive(false);
        }
        if (collision.gameObject.name == fifthTargetName)
        {
            findFifthTarget = true;
            GameObject hideObjecfit = GameObject.Find(fifthTargetName);
            hideObjecfit.SetActive(false);
            GameObject hideObjectfih = GameObject.Find(fifthHideName);
            hideObjectfih.SetActive(false);
        }

        if (findFirstTarget == true && findSecondTarget == true && findThirdTarget == true && findFourthTarget == true && findFifthTarget == true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}