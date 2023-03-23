using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRay : MonoBehaviour
{
    Ray ray; // ����
    Camera cam;

    void Start()
    {
        // Hierarchy ���� MainCamera Tag�� Camera return
        cam = Camera.main;
    }

    void Update()
    {
        // ScreenPointToRay : ���� ����
        ray = cam.ScreenPointToRay(Input.mousePosition);

        Debug.DrawLine(ray.origin, ray.direction * 500, Color.red);
    }
}
