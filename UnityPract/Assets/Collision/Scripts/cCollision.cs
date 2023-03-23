using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCollision : MonoBehaviour
{
    // Rigidbody - isKinematic�� ��Ȱ��ȭ ���� ��
    // �� ������Ʈ�� Collider�� isTrigger�� false

    // �浹 �� 1ȸ
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Debug.Log("OnCollisionEnter");
        }
    }

    // �浹 �� �ݹ�
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Debug.Log("OnCollisionStay");
        }
    }

    // �浹 ����
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Debug.Log("OnCollisionExit");
        }
    }
}
