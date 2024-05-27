using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float speed = 5.0f; // 노트 이동 속도 설정

    void Update()
    {
        // 노트를 아래로 이동시킵니다.
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // 노트가 화면을 벗어나면 제거합니다.
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 노트가 히트존에 도달했을 때 로직을 추가할 수 있습니다.
        if (other.CompareTag("Perfect") || other.CompareTag("Nice") || other.CompareTag("Miss"))
        {
            // 적절한 판정 로직을 여기에 추가할 수 있습니다.
        }
    }
}