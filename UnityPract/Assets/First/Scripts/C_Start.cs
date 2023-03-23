using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Start : MonoBehaviour
{
    // * MonoBehavior
    // 해당 클래스를 통해 오브젝트에 부착 가능

    // * Callback
    // 사용자가 호출하지 않아도 호출되는 함수
    // = start, update

    // * Lifecycle
    // 콜백함수들이 호출되는 순서

    // * Awake
    // start < awake, 가장 먼저 시작됨

    // * OnEnable
    // 활성화될떄마다 호출
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
