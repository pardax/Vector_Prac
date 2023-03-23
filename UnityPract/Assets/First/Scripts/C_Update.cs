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
    // update 후에 호출, 주로 카메라 이동에 사용
    private void LateUpdate()
    {
        Debug.Log("LateUpdate : " + Time.deltaTime);
    }

    // * FixedUpdate
    // 일정한 주기로 호출, 물리엔진 계산 주기와 일치
    // 주로 물리관련 계산에 사용
    // Edit > Project Setting > Time 을 통해 간격 조절 가능
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate : " + Time.deltaTime);
    }
}
