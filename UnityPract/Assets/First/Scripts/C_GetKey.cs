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
        //���������� true ��ȯ
        if(Input.GetKey(KeyCode.Q)) { Debug.Log("getKey"); }
        //Ű�� �������� 1ȸ true ��ȯ
        if (Input.GetKeyDown(KeyCode.N)) { Debug.Log("getKeyDown"); }
        //Ű�� ���� �� 1ȸ true ��ȯ
        if (Input.GetKeyUp(KeyCode.E)) { Debug.Log("getKeyUp"); }   
    }
}
