using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ��Ʈ�� ���ߴ� ���� �߰�
            CheckNoteHit();
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.L))
        {
            // �����̵� ��Ʈ�� ���ߴ� ���� �߰�
            CheckSlideNoteHit();
        }
    }

    void CheckNoteHit()
    {
        // ��Ʈ ��Ʈ üũ ����
    }

    void CheckSlideNoteHit()
    {
        // �����̵� ��Ʈ ��Ʈ üũ ����
    }
}
