using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 노트를 맞추는 로직 추가
            CheckNoteHit();
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.L))
        {
            // 슬라이드 노트를 맞추는 로직 추가
            CheckSlideNoteHit();
        }
    }

    void CheckNoteHit()
    {
        // 노트 히트 체크 로직
    }

    void CheckSlideNoteHit()
    {
        // 슬라이드 노트 히트 체크 로직
    }
}
