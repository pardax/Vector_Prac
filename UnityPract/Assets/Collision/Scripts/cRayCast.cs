using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRayCast : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Camera cam;

    void Start()
    {
        cam = Camera.main;    
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            
            // ray가 collider와 충돌했다면 true
            // 충돌 정보를 hit에 할당
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Ground"))
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.CompareTag("Enemy"))
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.CompareTag("Boss"))
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
