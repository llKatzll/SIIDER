using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    [SerializeField] private GameObject _notePrefab; //��Ʈ ����
    [SerializeField] private GameObject _slideNotePrefab; // �����̵� ��Ʈ ������
    [SerializeField] private float bpm = 120.0f; //��Ʈ �д� �ӵ� ����

    private float _beatInterval; //�� ��Ʈ�� ������ �� ������ ����
    private float _nextBeatTime; //���� ��Ʈ�� �߻��� �ð� ���

    void Start()
    {
        _beatInterval = 60.0f / bpm; //beat per min ���ϱ�, bpm�� 120�� ���, 1�п� 120���� ��Ʈ�� �߻��Ѵ�. bpm�� 120�� ���, ��Ʈ ������ ������ 0.5�ʴ�.
        _nextBeatTime = Time.time + _beatInterval; // ���� �ð�(Time.time)�� beatInterval�� ���Ͽ� ù ��° ��Ʈ�� �߻��� �ð��� �����Ѵ�.
    }

    void Update()
    {
        if (Time.time >= _nextBeatTime) //���� �ð��� ���� ��Ʈ �߻� �ð� �̻����� Ȯ��
        {
            Instantiate(_notePrefab, transform.position, Quaternion.identity); //notePrefab�� ���� ��ġ(transform.position)�� ����, Quaternion.identity�� ȸ�� ���� �������� �ǹ�.
            _nextBeatTime += _beatInterval; //���� ��Ʈ �߻� �ð��� ���� ��Ʈ �߻� �ð��� beatInterval�� ���� ������Ʈ�մϴ�.

            // �����̵� ��Ʈ ���� (���÷� 4��Ʈ���� ����)
            if (Random.Range(0, 4) == 0)
            {
                Instantiate(_slideNotePrefab, transform.position, Quaternion.identity);
            }
        }
    }
}