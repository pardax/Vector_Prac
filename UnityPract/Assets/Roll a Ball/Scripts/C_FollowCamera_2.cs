using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_FollowCamera_2 : MonoBehaviour
{
    public GameObject target;
    Vector3 offset; //�Ÿ�

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
        //Ÿ�ٰ��� �Ÿ��� offset�� ����
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //ó�� �Ÿ��� ��� ����
        transform.position = target.transform.position + offset;
    }
}
