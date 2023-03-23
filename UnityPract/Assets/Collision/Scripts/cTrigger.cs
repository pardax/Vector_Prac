using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTrigger : MonoBehaviour
{
    // 각 오브젝트에 Rigidbody 보유
    // 각 오브젝트 중 하나 이상이 isTrigger-True

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
