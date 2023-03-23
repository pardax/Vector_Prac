using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Start : MonoBehaviour
{
    // * MonoBehavior
    // �ش� Ŭ������ ���� ������Ʈ�� ���� ����

    // * Callback
    // ����ڰ� ȣ������ �ʾƵ� ȣ��Ǵ� �Լ�
    // = start, update

    // * Lifecycle
    // �ݹ��Լ����� ȣ��Ǵ� ����

    // * Awake
    // start < awake, ���� ���� ���۵�

    // * OnEnable
    // Ȱ��ȭ�ɋ����� ȣ��
    void Start()
    {
        Debug.Log("cube script initiated");
    }

    void Update()
    {
        
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
