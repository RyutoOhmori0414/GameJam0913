using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float _movespeed;
    [SerializeField] float _movespeed2;
    [SerializeField] float _hp;
    Rigidbody2D _rb;
    [SerializeField]Vector3 _target;
    [SerializeField] Vector3 _position;
    float _distance;
    [SerializeField] float _stop;
    float _randomcount = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        EnemyMoves();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    EnemyMoves();
    //}
    public void EnemyDamege(int damage)
    {
        _hp -= damage;
        if(_hp >= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void EnemyMoves()
    {
        _position = this.transform.position;
        _target = GameObject.FindGameObjectWithTag("Snack").transform.position;
        _distance = Vector3.Distance(_position, _target);
       if(_distance >= _stop)
        {
                Vector3 dir = (_target - this.transform.position).normalized * _movespeed;
                _rb.velocity = dir * _movespeed2;
            if(_target.x > this.transform.position.x)
            {
                transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
            }
            else
            {
                transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Snack")
        {
            Destroy(this.gameObject);
        }
    }
}
