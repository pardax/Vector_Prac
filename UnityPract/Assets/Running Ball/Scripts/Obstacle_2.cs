using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * 10 * Time.deltaTime, Space.World);        
    }
}
