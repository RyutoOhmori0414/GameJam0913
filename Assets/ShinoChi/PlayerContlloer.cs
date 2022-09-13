using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContlloer : MonoBehaviour
{
    [SerializeField] float movePower = 10f;
    [SerializeField] GameObject attack = null;
    [SerializeField] Transform attackPoint = null;
    [SerializeField, Range(0, 10)] int attackLimit = 0;
    Rigidbody2D _rb;

    float _attackcounter = 0;
    public float AttackCounter
    {
        get => _attackcounter;
    }

    //Animator _ani;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
      //  _ani = GetComponent<Animator>();
        _attackcounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float yoko = Input.GetAxisRaw("Horizontal");
        float tate = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(yoko, tate).normalized;
        _rb.velocity = dir * movePower;
        if (_rb.velocity != Vector2.zero)
        {
            this.transform.up = _rb.velocity;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Fire1();
        }
    }

    void Fire1()
    {
        if (attack && attackPoint) 
        {
            GameObject go = Instantiate(attack, attackPoint.position, attack.transform.rotation); 
            go.transform.SetParent(this.transform);
           // _ani.Play("attack");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            _attackcounter++;
        }
    }
}
