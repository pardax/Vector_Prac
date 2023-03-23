using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Destroy(this.gameObject, 3.0f);
        }

    }
}
