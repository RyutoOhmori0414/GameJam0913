using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{
    
    [Header("TitleScene‚Ì–¼‘O"), SerializeField] string _titleSceneName;
    // Start is called before the first frame update
   

   
    public void TitleScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_titleSceneName);
    }
}
