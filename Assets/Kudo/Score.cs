using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    private int _score = 0;
    private float scoreChangeSpeed = 2f;
    [SerializeField] Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreChangeValue((int)GameManager.Score);
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = $"{String.Format("{0:000000000}", _score)}";
    }

    void ScoreChangeValue(int score)
    {
        DOTween.To(() => _score, x => _score = x, score, scoreChangeSpeed);
    }

    private void OnDisable()
    {
        GameManager.ScoreReset();
    }
}
