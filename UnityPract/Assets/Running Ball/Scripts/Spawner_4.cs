using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_4 : MonoBehaviour
{
    public GameObject opstacle;
    public GameObject coin;
    public GameObject seringe;

    // Start is called before the first frame update
    void Start()
    {
        //IEnumerator 가 반환형인 함수를 호출
        StartCoroutine(ObjectSpawn());
    }

    IEnumerator ObjectSpawn()
    {
        int ran = Random.Range(0, 10);
        
        if(ran > 0 && ran < 4)
        {
            Instantiate(opstacle, transform.position, Quaternion.identity);
        }
        else if (ran > 4 && ran < 7)
        {
            Instantiate(seringe, transform.position, Quaternion.identity);
        }
        else 
        {
            Instantiate(coin, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(2f);
        StartCoroutine(ObjectSpawn());
    }
    
}
