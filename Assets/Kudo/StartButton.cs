using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("GameScene"), SerializeField] string _gameSceneName;
    [SerializeField] GameObject startButton;
    // Start is called before the first frame update
    private void Start()
    {
        startButton.GetComponent<Animator>().enabled = false;
    }
    public void GameScene()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        startButton.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(_gameSceneName);
    }
}
