using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    [SerializeField] private GameObject _notePrefab; //노트 설정
    [SerializeField] private GameObject _slideNotePrefab; // 슬라이드 노트 프리팹
    [SerializeField] private float bpm = 120.0f; //비트 분당 속도 저장

    private float _beatInterval; //각 비트의 간격을 초 단위로 저장
    private float _nextBeatTime; //다음 비트가 발생할 시간 계산

    void Start()
    {
        _beatInterval = 60.0f / bpm; //beat per min 구하기, bpm이 120일 경우, 1분에 120개의 비트가 발생한다. bpm이 120일 경우, 비트 사이의 간격은 0.5초다.
        _nextBeatTime = Time.time + _beatInterval; // 현재 시간(Time.time)에 beatInterval을 더하여 첫 번째 비트가 발생할 시간을 설정한다.
    }

    void Update()
    {
        if (Time.time >= _nextBeatTime) //현재 시간이 다음 비트 발생 시간 이상인지 확인
        {
            Instantiate(_notePrefab, transform.position, Quaternion.identity); //notePrefab을 현재 위치(transform.position)에 생성, Quaternion.identity는 회전 없이 생성함을 의미.
            _nextBeatTime += _beatInterval; //다음 비트 발생 시간을 현재 비트 발생 시간에 beatInterval을 더해 업데이트합니다.

            // 슬라이드 노트 생성 (예시로 4비트마다 생성)
            if (Random.Range(0, 4) == 0)
            {
                Instantiate(_slideNotePrefab, transform.position, Quaternion.identity);
            }
        }
    }
}