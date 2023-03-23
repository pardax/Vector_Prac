using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_GetAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Input.GetAxis : 키를 눌렀을떄 -1~1 사이값 반환


        this.transform.position = new Vector3(h, v, 0);
        Debug.Log("h : " +  h);
        Debug.Log("v : " + v);

    }
}
