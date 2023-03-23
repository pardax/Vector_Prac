using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class C_TimeScale : MonoBehaviour
{
    float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x < -7f) { speed = 5f; }
        if (transform.position.x > 7f) { speed = -5f; }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Time.timeScale = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 1.0f; 
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Time.timeScale = 2.0f;
        }
    }
}
