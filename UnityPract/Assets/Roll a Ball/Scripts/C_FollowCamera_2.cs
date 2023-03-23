using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_FollowCamera_2 : MonoBehaviour
{
    public GameObject target;
    Vector3 offset; //거리

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
        //타겟과의 거리를 offset에 저장
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //처음 거리를 계속 유지
        transform.position = target.transform.position + offset;
    }
}
