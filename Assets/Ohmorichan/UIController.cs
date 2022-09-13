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
    
    public void GameEnd()
    {
        _fade.DOFade(1f, 3f).OnComplete(() => SceneManager.LoadScene(_sceneName));
    }
}
