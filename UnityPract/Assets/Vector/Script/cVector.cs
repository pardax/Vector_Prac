using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cVector : MonoBehaviour
{
    // 위치좌표 (절대좌표)
    // 원점으로부터 얼마나 떨어져 있는지 나타내는 좌표
    // 점으로 나타낼 수 있다.
    // 방향의 개념으로 볼 수 있다 (원점으로부터 향하는 방향으로 볼 수 있기 때문)

    // 방향 (상대좌표)
    // 어떤방향으로 얼만큼의 길이를 가지는지
    // 출발위치에 대한 정보는 가지고 있지 않음
    // 화살표로 나타낼 수 있다.

    // 벡터의 길이 (크기)
    // magitude
    // 선의 실제 길이
    // Vector2(4, 3)이 있다면 벡터의 길이는 5
    // 실제 이동한 거리는 5이고 (4, 3)의 방향을 나타낸다
    // 각 원소를 제곱한 뒤 더하여 제곱근을 구하면 벡터의 길이가 나옴
    
    // * 피타고라스 밑변제곱 + 높이제곱 n^2 + h^2 = k
    // k 루트 = 대각선

    // 벡터의 덧셈
    // 어떤 절대적 위치좌표에서 벡터만큼 이동
    // vector(1, 1) + vector(-3, 3) = vector(-2, 4);

    // 벡터의 뺄셈
    // 목표위치 - 현재위치 = 목표위치로의 방향 및 거리

    // 벡터의 정규화
    // 벡터의 방향을 유지한채 길이를 1로 만드는 것
    // 각 원소를 벡터의 길이로 나누어주면 됨
    // vector(2, 2)의 벡터의 길이는 약 2.82
    // 해당벡터를 정규화하면 약 vector(0.709, 0.709) (2/2.82)
    // 벡터의 길이를 구하면 약 1이 나온다.

    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(h, v, 0);
            //normalized = 정규화
            //대각선으로 이동시 v3(1, 1, 0) 로, 2(1, 1)의거리를 대각선 피타고라스의 정리를 적용하였을 때 1.4가 되기때문에 더 빠르다
            //이 빠른점을 개선하기 위해 정규화를 통해서 (0.7, 0.7) 로 정규화시킨다
            Debug.Log(movement.normalized);
            transform.Translate(movement.normalized * 3 * Time.deltaTime);

        }
    }
}
