using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContlloer : MonoBehaviour
{
    [SerializeField] float movePower = 10f;
    [SerializeField] GameObject attack = null;
    
    
    CircleCollider2D attackcollider;
    Rigidbody2D _rb;
    AudioSource _audio;
    bool _move = false;

    float _attackcounter = 0;
    public float AttackCounter
    {
        get => _attackcounter;
    }

    private void OnEnable()
    {
        GameManager.GameStart += PlayerStart;
    }

    //Animator _ani;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        attackcollider = GetComponent<CircleCollider2D>();
        attackcollider.enabled = false;
      //  _ani = GetComponent<Animator>();
        _attackcounter = 0;
        _move = false;
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_move)
        {
            float yoko = Input.GetAxisRaw("Horizontal");
            float tate = Input.GetAxisRaw("Vertical");
            Vector2 dir = new Vector2(yoko, tate).normalized;
            _rb.velocity = dir * movePower;
            //if (_rb.velocity != Vector2.zero)
            //{
            //    this.transform.up = _rb.velocity;
            //}

            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(Collider());
                Fire1();
                _audio.Play();
            }
        }
        
    }

    void Fire1()
    {
        if (attack) 
        {
            GameObject go =  Instantiate(attack, transform.position, Quaternion.identity); 
            go.transform.SetParent(this.gameObject.transform);
           
            // _ani.Play("attack");
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            _attackcounter++;
        }
    }

    IEnumerator Collider()  //攻撃判定のコライダーを0.3秒だけ表示
    {
        attackcollider.enabled = true;
        yield return new WaitForSeconds(0.3f);
        attackcollider.enabled = false;
    }

    void PlayerStart()
    {
        _move = true;
    }

    private void OnDisable()
    {
        GameManager.GameStart -= PlayerStart;
    }
}
