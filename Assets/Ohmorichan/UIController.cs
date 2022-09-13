using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Tooltip("フェード"), SerializeField] Image _fade;
    [Tooltip("フェードが終わったら呼ぶSceneの名前"), SerializeField] string _sceneName;
    
    public void GameEnd()
    {
        _fade.DOFade(2f, 3f).OnComplete(() => SceneManager.LoadScene(_sceneName));
    }
}
