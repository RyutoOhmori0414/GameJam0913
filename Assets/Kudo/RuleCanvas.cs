using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleCanvas : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject HelpButton;
    [SerializeField] GameObject CloseButton;
    // Start is called before the first frame update
    void Start()
    {
        HelpButton.GetComponent<Animator>().enabled = false;
        CloseButton.GetComponent<Animator>().enabled = false;
        _canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCanvas()
    {
        StartCoroutine(Animation());
    }

    public void OffCanvas()
    {
        StartCoroutine(Animation2());
    }

    IEnumerator Animation()
    {
        HelpButton.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        _canvas.SetActive(true);
        HelpButton.GetComponent<Animator>().enabled = false;
    }

    IEnumerator Animation2()
    {
        CloseButton.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        _canvas.SetActive(false);
        CloseButton.GetComponent<Animator>().enabled = false;
    }
}
