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
            
            // ray�� collider�� �浹�ߴٸ� true
            // �浹 ������ hit�� �Ҵ�
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
