using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleCanvas : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    // Start is called before the first frame update
    void Start()
    {
        _canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCanvas()
    {
        _canvas.SetActive(true);
    }

    public void OffCanvas()
    {
        _canvas.SetActive(false);
    }
}
