using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Player_1 : MonoBehaviour
{

    Vector3 startPos;   //마우스 클릭 시작 좌표
    Vector3 currentPos; // 마우스의 현재 위치
    Vector3 direction;  // 마우스가 움직인 방향
    Vector3 target;     // 목표지점

    public TMP_Text text;
    public TMP_Text txtHP;

    public Button btn;
    int score;
    int life;

    Rigidbody rb;

    int cnt = 0;
    bool isGround = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        this.life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            currentPos = Input.mousePosition;
            direction = currentPos - startPos;
            if (direction.x > 50)
            {
                cnt++;
                if (cnt >= 2) cnt = 2;
            }
            if (direction.x < -50)
            {
                cnt--;
                if (cnt <= -2) cnt = -2;
            }
            if (direction.y > 50 && isGround)
            {
                rb.AddForce(new Vector3(0, 300, 0));
                isGround = false;
            }
        }

        target = transform.position;
        switch (cnt)
        {
            case -2:
                target.x = -4;
                break;
            case -1:
                target.x = -2;
                break;
            case 0:
                target.x = 0;
                break;
            case 1:
                target.x = 2;
                break;
            case 2:
                target.x = 4;
                break;
        }

        if (Vector3.Distance(target, transform.position) > 0.02f)
        {
            transform.Translate((target - transform.position).normalized * 5 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            score += 10;
            text.text = score.ToString();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
            life++;
            txtHP.text = string.Format("HP : {0}", life);
        }
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            if(life > 0)
            {
                life--;
                txtHP.text = string.Format("HP : {0}", life);
            }
            else
            {
                Time.timeScale = 0;
                btn.gameObject.SetActive(true);
            }
        }
    }

    // Collider에 isTrigger가 둘 다 비활성화
    // 스크립트가 들어간 오브젝트에 rigidbody가 있어야함
    // 충돌시 호출되는 생명주기 함수
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
