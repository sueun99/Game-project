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

    public string sceneName;  // 씬 이름 : Inspector에 지정

    public AudioClip effectSound;

    public float volumn = 1.0f;

    private bool findFirstTarget = false;
    private bool findSecondTarget = false;
    private bool findThirdTarget = false;
    private bool findFourthTarget = false;
    private bool findFifthTarget = false;

    AudioSource audioSource = null;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = effectSound;
        audioSource.volume = volumn;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
    {
        // 만약 충돌한 것의 이름이 목표 오브젝트였다면
        if (collision.gameObject.name == firstTargetName)
        {
            findFirstTarget = true;
            GameObject hideObjectft = GameObject.Find(firstTargetName);
            hideObjectft.SetActive(false);
            GameObject hideObjectfh = GameObject.Find(firstHideName);
            hideObjectfh.SetActive(false);
            if (effectSound != null)
            {
                audioSource.Play();
            }
        }
        if (collision.gameObject.name == secondTargetName)
        {
            findSecondTarget = true;
            GameObject hideObjectst = GameObject.Find(secondTargetName);
            hideObjectst.SetActive(false);
            GameObject hideObjectsh = GameObject.Find(secondHideName);
            hideObjectsh.SetActive(false);
            if (effectSound != null)
            {
                audioSource.Play();
            }
        }
        if (collision.gameObject.name == thirdTargetName)
        {
            findThirdTarget = true;
            GameObject hideObjecttt = GameObject.Find(thirdTargetName);
            hideObjecttt.SetActive(false);
            GameObject hideObjectth = GameObject.Find(thirdHideName);
            hideObjectth.SetActive(false);
            if (effectSound != null)
            {
                audioSource.Play();
            }
        }
        if (collision.gameObject.name == fourthTargetName)
        {
            findFourthTarget = true;
            GameObject hideObjectfot = GameObject.Find(fourthTargetName);
            hideObjectfot.SetActive(false);
            GameObject hideObjectfoh = GameObject.Find(fourthHideName);
            hideObjectfoh.SetActive(false);
            if (effectSound != null)
            {
                audioSource.Play();
            }
        }
        if (collision.gameObject.name == fifthTargetName)
        {
            findFifthTarget = true;
            GameObject hideObjecfit = GameObject.Find(fifthTargetName);
            hideObjecfit.SetActive(false);
            GameObject hideObjectfih = GameObject.Find(fifthHideName);
            hideObjectfih.SetActive(false);
            if (effectSound != null)
            {
                audioSource.Play();
            }
        }

        if (findFirstTarget == true && findSecondTarget == true && findThirdTarget == true && findFourthTarget == true && findFifthTarget == true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
