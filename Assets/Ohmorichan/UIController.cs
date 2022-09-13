using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    [Tooltip("フェードさせるパネル"), SerializeField] Image _fade;
    [Tooltip("フェードさせた後に呼び出すシーンの名前"), SerializeField] string _sceneName;
    [Tooltip("タイムを表示するテキスト"), SerializeField] Text _timerText;

    bool _move = false;
    float _timer = default;
    bool _isCountTime = false;

    private void OnEnable()
    {
        GameManager.GameStart += UIStart;
    }
    private void Start()
    {
        _isCountTime = false;
        _move = false;
    }

    private void Update()
    {
        if (_isCountTime)
        {
            _timer += Time.deltaTime;
            _timerText.text = _timer.ToString("0000.00");
        }
    }

    void TimerStop()
    {
        _isCountTime = false;
    }

    void UIStart()
    {
        _move = true;
        _isCountTime = true;
    }
    public void GameEnd()
    {
        TimerStop();
        _fade.DOFade(1f, 3f).OnComplete(() => SceneManager.LoadScene(_sceneName));
    }

    private void OnDisable()
    {
        GameManager.GameStart -= UIStart;
    }
}
