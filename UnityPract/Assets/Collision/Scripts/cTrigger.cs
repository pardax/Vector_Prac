using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTrigger : MonoBehaviour
{
    // �� ������Ʈ�� Rigidbody ����
    // �� ������Ʈ �� �ϳ� �̻��� isTrigger-True

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("OnTriggerEnter");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            Debug.Log("OnTriggerStay");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            Debug.Log("OnTriggerExit");
        }
    }
}
