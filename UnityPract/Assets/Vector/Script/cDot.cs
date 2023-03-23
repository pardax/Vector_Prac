using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cDot : MonoBehaviour
{
    // ������ ����
    // ������ �� ���ҳ��� ���� �� ��� ���ϸ� ������ ���� �� ����
    // v1, v2�� ���� : (v1.x * v2.x) + (v1.y * v2.y) , �ش� ������ Dot �Լ��� ���� ����
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
