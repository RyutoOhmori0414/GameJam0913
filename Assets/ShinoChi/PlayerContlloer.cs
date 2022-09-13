using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContlloer : MonoBehaviour
{
    [SerializeField] float movePower = 10f;
    //[SerializeField] float movePower;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float yoko = Input.GetAxisRaw("Horizontal");
        float tate = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(yoko, tate).normalized;
        _rb.velocity = dir * movePower;
    }
}
