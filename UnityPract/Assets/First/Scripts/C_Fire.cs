using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Fire : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
