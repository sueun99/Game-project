using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    public float time = 60;
    public string frontMessage = "";
    public string backMessage = "";
    public string sceneName;  // 씬 이름 : Inspector에 지정

    private void Awake()
    {

    }

    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }

        timeText.text = string.Format("{0}{1}{2}", frontMessage, Mathf.Ceil(time).ToString(), backMessage);
    }
}
