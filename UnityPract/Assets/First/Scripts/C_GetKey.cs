using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //지속적으로 true 반환
        if(Input.GetKey(KeyCode.Q)) { Debug.Log("getKey"); }
        //키를 눌렀을때 1회 true 반환
        if (Input.GetKeyDown(KeyCode.N)) { Debug.Log("getKeyDown"); }
        //키를 땟을 때 1회 true 반환
        if (Input.GetKeyUp(KeyCode.E)) { Debug.Log("getKeyUp"); }   
    }
}
