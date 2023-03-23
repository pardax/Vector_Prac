using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCross : MonoBehaviour
{
    // ������ ����
    // ����(������)�� �� ���Ϳ� �����ϴ� ������� ����
    // �� ���Ϳ� 90�� ���� �̷�� ���͸� �ǹ�
    // 3���� ���������� ����
    // �̷��� ���� ���͸� �������� Ȥ�� ��ֺ��Ͷ�� �Ѵ�


    void Start()
    {
        Vector3 v1 = new Vector3 (2, 3, 5);
        Vector3 v2 = new Vector3(4, 2, 1);

        float x = v1.y * v2.z - v1.z * v2.y;
        float y = v1.z * v2.x - v1.x * v2.z;
        float z = v1.x * v2.y - v1.y * v2.x;

        Vector3 result = new Vector3(x, y, z);
        Debug.Log("���� ���� : " + result);

        result = Vector3.Cross(v1, v2);
        Debug.Log("���� ���� : " + result);
    }

    public Transform enemy;
    public TMPro.TMP_Text txt;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * 3, Color.red);

        Vector3 cross = Vector3.Cross(transform.forward, enemy.position - transform.position);
        Debug.DrawLine(transform.position, cross, Color.green);


        float dot = Vector3.Dot(cross, transform.up);
        //���� ���͸� ���� (������)
        
        txt.text = dot < 0 ? "left" : "right";


    }
}
