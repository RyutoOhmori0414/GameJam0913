using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _score = default;
    public int Score
    {
        get => _score;
    }

    float _timer = default;

    private void Update()
    {
        _timer += Time.deltaTime;
        // score�Ƀ^�C���Ɠ|�����G�̐����ӂ݂��X�R�A��������
        _score = (int)_timer + (/*�|�����G*/10) * 100; 
    }
}
