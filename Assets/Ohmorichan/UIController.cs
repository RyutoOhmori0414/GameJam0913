using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Tooltip("�t�F�[�h"), SerializeField] Image _fade;
    [Tooltip("�t�F�[�h���I�������Ă�Scene�̖��O"), SerializeField] string _sceneName;
    
    public void GameEnd()
    {
        _fade.DOFade(2f, 3f).OnComplete(() => SceneManager.LoadScene(_sceneName));
    }
}
