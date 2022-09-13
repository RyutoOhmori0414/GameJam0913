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
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMoves();
    }
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
        _target = GameObject.FindGameObjectWithTag("Snak").transform.position;
        _distance = Vector3.Distance(_position, _target);
       if(_distance >= _stop)
        {
            var random = Random.Range(0, 1f);
            if(_randomcount > random)
            {
                Vector3 dir = (_target - this.transform.position).normalized * _movespeed;
                _rb.velocity = dir * _movespeed2;
            }
            //else if(_randomcount < random)
            //{
                //float sin = Mathf.Sin(Time.time);
                //this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y + sin, 0);
                //Vector3 dir = (_target - this.transform.position).normalized * _movespeed;
               // _rb.velocity = dir * _movespeed2;
            //}
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Snak")
        {
            Destroy(this.gameObject);
        }
    }
}
