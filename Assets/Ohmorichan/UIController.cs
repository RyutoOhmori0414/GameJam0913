using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    [Tooltip("�t�F�[�h������p�l��"), SerializeField] Image _fade;
    [Tooltip("�t�F�[�h��������ɌĂяo���V�[���̖��O"), SerializeField] string _sceneName;
    [Tooltip("�^�C����\������e�L�X�g"), SerializeField] Text _timerText;

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
