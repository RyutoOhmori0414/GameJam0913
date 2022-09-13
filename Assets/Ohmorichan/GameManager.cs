using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static Action GameStart;

    bool _start = false;

    static float _score = default;
    public static float Score
    {
        get => _score;
    }

    float _timer = default;
    PlayerContlloer _contlloer;
    private void Start()
    {
        _start = true;
        _contlloer = FindObjectOfType<PlayerContlloer>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        // score�Ƀ^�C���Ɠ|�����G�̐����ӂ݂��X�R�A��������
        _score = _timer + (_contlloer.AttackCounter * 10) * 100; 
        if (_timer > 3f && _start)
        {
            GameStart.Invoke();
            _start = false;
        }
    }

    static public void ScoreReset()
    {
        _score = 0;
    }
}
