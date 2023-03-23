using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class C_Player_1 : MonoBehaviour
{
    Rigidbody rb;
    public TMP_Text text;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            Vector3 movement = new Vector3 (h, 0, v);
            transform.Translate(movement * 3 * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0));
        }

    }
    //rigid && isTrigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            text.SetText("Score : {0}", ++count);
        }
    }
}
