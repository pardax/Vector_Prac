using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 30, 30) * 5 * Time.deltaTime);
        transform.Translate(Vector3.back * 10 * Time.deltaTime, Space.World);    
    }
}
