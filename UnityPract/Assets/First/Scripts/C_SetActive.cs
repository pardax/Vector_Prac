using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_SetActive : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            obj.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            obj.SetActive(true);
        }

    }
}
