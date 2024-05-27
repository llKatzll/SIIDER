using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float speed = 5.0f; // ��Ʈ �̵� �ӵ� ����

    void Update()
    {
        // ��Ʈ�� �Ʒ��� �̵���ŵ�ϴ�.
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // ��Ʈ�� ȭ���� ����� �����մϴ�.
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // ��Ʈ�� ��Ʈ���� �������� �� ������ �߰��� �� �ֽ��ϴ�.
        if (other.CompareTag("Perfect") || other.CompareTag("Nice") || other.CompareTag("Miss"))
        {
            // ������ ���� ������ ���⿡ �߰��� �� �ֽ��ϴ�.
        }
    }
}