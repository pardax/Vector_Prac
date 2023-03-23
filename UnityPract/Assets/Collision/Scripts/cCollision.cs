using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCollision : MonoBehaviour
{
    // Rigidbody - isKinematic이 비활성화 여야 함
    // 각 오브젝트의 Collider에 isTrigger가 false

    // 충돌 시 1회
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Debug.Log("OnCollisionEnter");
        }
    }

    // 충돌 중 콜백
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Debug.Log("OnCollisionStay");
        }
    }

    // 충돌 해제
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Debug.Log("OnCollisionExit");
        }
    }
}
