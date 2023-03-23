using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Practice1 : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.position += Vector3.down * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
    }
}
