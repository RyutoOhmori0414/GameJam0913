using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("GameScene"), SerializeField] string _gameSceneName;
    // Start is called before the first frame update

    public void GameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_gameSceneName);
    }
}
