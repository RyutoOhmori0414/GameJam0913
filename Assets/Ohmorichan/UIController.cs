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
    
    public void GameEnd()
    {
        _fade.DOFade(1f, 3f).OnComplete(() => SceneManager.LoadScene(_sceneName));
    }
}
