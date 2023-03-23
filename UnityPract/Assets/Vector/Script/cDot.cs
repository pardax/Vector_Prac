using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cDot : MonoBehaviour
{
    // 벡터의 내적
    // 벡터의 각 원소끼리 곱한 뒤 모두 더하면 내적을 구할 수 있음
    // v1, v2의 내적 : (v1.x * v2.x) + (v1.y * v2.y) , 해당 연산은 Dot 함수를 통해 가능
    // 

    public Transform enemy;
    public TMPro.TMP_Text dotText;

    // Update is called once per frame
    void Update()
    {
        //foward is direction
        Debug.DrawLine(transform.position, transform.position + transform.forward * 5 , Color.red);

        float dot = Vector3.Dot(transform.forward, enemy.position - transform.position);
        string strDot = (dot >= 0) ? "Front" : "Back";
        dotText.text = string.Format("dot value : {0} / Direction : {1}", dot, strDot);
        
    }
}
