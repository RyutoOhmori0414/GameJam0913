using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{
    
    [Header("TitleScene‚Ì–¼‘O"), SerializeField] string _titleSceneName;
    [SerializeField] GameObject button;
    // Start is called before the first frame update

    private void Start()
    {
        button.GetComponent<Animator>().enabled = false;
    }
    public void GameScene()
    {
        StartCoroutine(Animation());
    }


    public void TitleScene()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        button.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(_titleSceneName);
        button.GetComponent<Animator>().enabled = false;
    }
}
