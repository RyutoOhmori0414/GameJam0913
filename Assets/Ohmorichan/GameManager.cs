using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static float _score = default;
    public float Score
    {
        get => _score;
    }

    float _timer = default;
    PlayerContlloer _contlloer;
    private void Start()
    {
        _contlloer = FindObjectOfType<PlayerContlloer>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        // scoreにタイムと倒した敵の数を鑑みたスコアを代入する
        _score = _timer + (_contlloer.AttackCounter * 10) * 100; 
    }

    void ScoreReset()
    {
        _score = 0;
    }
}
