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
        // scoreにタイムと倒した敵の数を鑑みたスコアを代入する
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
