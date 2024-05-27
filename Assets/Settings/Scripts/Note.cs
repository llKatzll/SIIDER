using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); //정해진 스피드만큼 수직낙하

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("HitZone"))
        {
            // 노트가 히트존에 도달했을 때의 처리 로직
        }
    }
}