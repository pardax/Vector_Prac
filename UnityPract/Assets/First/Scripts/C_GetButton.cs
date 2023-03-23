using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_GetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) { Debug.Log("getBtn"); }
        if (Input.GetButtonDown("Fire2")) { Debug.Log("getBtnDown"); }
        if (Input.GetButtonUp("Fire3")) { Debug.Log("getBtnUp"); }


    }
}
