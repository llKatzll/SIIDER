using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Transform hitZone1;
    public Transform hitZone2;
    public Transform hitZone3;
    public Transform hitZone4;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CheckNoteHit(hitZone1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            CheckNoteHit(hitZone2);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            CheckNoteHit(hitZone3);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            CheckNoteHit(hitZone4);
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.L))
        {
            CheckSlideNoteHit();
        }
    }

    void CheckNoteHit(Transform hitZone)
    {
        RaycastHit2D hit = Physics2D.Raycast(hitZone.position, Vector2.down);
        if (hit.collider != null && hit.collider.CompareTag("Note"))
        {
            Destroy(hit.collider.gameObject);
            // 점수 추가 등 추가 로직
        }
    }

    void CheckSlideNoteHit()
    {
        // 슬라이드 노트 히트 체크 로직
        RaycastHit2D hit1 = Physics2D.Raycast(hitZone1.position, Vector2.down);
        RaycastHit2D hit2 = Physics2D.Raycast(hitZone2.position, Vector2.down);
        RaycastHit2D hit3 = Physics2D.Raycast(hitZone3.position, Vector2.down);
        RaycastHit2D hit4 = Physics2D.Raycast(hitZone4.position, Vector2.down);

        if (hit1.collider != null && hit1.collider.CompareTag("SlideNote") &&
            hit2.collider != null && hit2.collider.CompareTag("SlideNote") &&
            hit3.collider != null && hit3.collider.CompareTag("SlideNote") &&
            hit4.collider != null && hit4.collider.CompareTag("SlideNote"))
        {
            Destroy(hit1.collider.gameObject);
            Destroy(hit2.collider.gameObject);
            Destroy(hit3.collider.gameObject);
            Destroy(hit4.collider.gameObject);
            // 점수 추가 등 추가 로직
        }
    }
}
