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
        // scoreにタイムと倒した敵の数を鑑みたスコアを代入する
        _score = (int)_timer + (/*倒した敵*/10) * 100; 
    }
}
