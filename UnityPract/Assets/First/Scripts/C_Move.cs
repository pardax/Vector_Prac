using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))    
        {
            //* ���� ��ǥ ���� 
            //transform.position += Vector3.left * Time.deltaTime * 3f;

            //* ���� ��ǥ ���� 
            transform.Translate(Vector3.left * Time.deltaTime * 3f);
            //transform.Translate(Vector3.left * Time.deltaTime * 3f, Space.World);
            //transform.Translate(Vector3.left * Time.deltaTime * 3f, Space.Self);

        }
    }
}
