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
        // score�Ƀ^�C���Ɠ|�����G�̐����ӂ݂��X�R�A��������
        _score = _timer + (_contlloer.AttackCounter * 10) * 100; 
    }

    void ScoreReset()
    {
        _score = 0;
    }
}
