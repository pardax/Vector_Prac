using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Update : MonoBehaviour
{
    
    void Update()
    {
        Debug.Log("Update : " + Time.deltaTime);
    }
    // * LateUpdate
    // update �Ŀ� ȣ��, �ַ� ī�޶� �̵��� ���
    private void LateUpdate()
    {
        Debug.Log("LateUpdate : " + Time.deltaTime);
    }

    // * FixedUpdate
    // ������ �ֱ�� ȣ��, �������� ��� �ֱ�� ��ġ
    // �ַ� �������� ��꿡 ���
    // Edit > Project Setting > Time �� ���� ���� ���� ����
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate : " + Time.deltaTime);
    }
}
