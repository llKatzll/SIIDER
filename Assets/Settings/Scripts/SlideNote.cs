using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideNote : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); //��������. ����

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("HitZone"))
        {
            // �����̵� ��Ʈ�� ��Ʈ���� �������� ���� ó�� ����
        }
    }
}