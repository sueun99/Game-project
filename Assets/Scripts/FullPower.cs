using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullPower : MonoBehaviour
{
    // �ν����Ϳ��� ���� ������ ��ҵ�
    public GameObject targetObject; // Ÿ�� ������Ʈ

    public AudioSource audioSource; // ����� �ҽ�
    public AudioClip audioClip; // ����� Ŭ��

    public GameObject objectToActivate; // Ȱ��ȭ �� ������Ʈ
    public GameObject objectToDeactivate; // ��Ȱ��ȭ �� ������Ʈ

    public GameObject otherObject; // �ٸ� ������Ʈ
    public string functionName; // ���� �� �Լ� �̸�

    public GameObject effectPrefab; // ����Ʈ ������
    public float effectDuration; // ����Ʈ ���� �� ���� �ð�
    public Vector3 effectPosition; // ����Ʈ �߻� ��ġ
    public float effectSize; // ����Ʈ ũ��

    public bool shouldDestroyTarget; // ������Ʈ ���� ����

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // PerformAction �Լ� ���� �� ����� ����
    public void PerformAction()
    {
        // ����� ���
        if (audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }

        // ������Ʈ Ȱ��ȭ/��Ȱ��ȭ
        if (objectToActivate != null)
            objectToActivate.SetActive(true);

        if (objectToDeactivate != null)
            objectToDeactivate.SetActive(false);

        // �ٸ� ������Ʈ�� �Լ� ����
        if (otherObject != null && !string.IsNullOrEmpty(functionName))
            otherObject.SendMessage(functionName, SendMessageOptions.DontRequireReceiver);

        // ����Ʈ ���� �� ����
        if (effectPrefab != null && targetObject != null)
        {
            Vector3 relativeEffectPosition = targetObject.transform.position + effectPosition;
            GameObject effect = Instantiate(effectPrefab, relativeEffectPosition, Quaternion.identity);
            effect.transform.localScale = new Vector3(effectSize, effectSize, effectSize);
            Destroy(effect, effectDuration);
        }

        // Ÿ�� ������Ʈ ����
        if (shouldDestroyTarget && targetObject != null)
            Destroy(targetObject);
    }
}
