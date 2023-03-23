using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRay : MonoBehaviour
{
    Ray ray; // ±¤¼±
    Camera cam;

    void Start()
    {
        // Hierarchy ¿¡¼­ MainCamera TagÀÇ Camera return
        cam = Camera.main;
    }

    void Update()
    {
        // ScreenPointToRay : ±¤¼± »ý¼º
        ray = cam.ScreenPointToRay(Input.mousePosition);

        Debug.DrawLine(ray.origin, ray.direction * 500, Color.red);
    }
}
