using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyR : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    [SerializeField] float _cooltime;
    float _time;
    [SerializeField] Vector3 _target;

    GameObject _snack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _snack = GameObject.FindGameObjectWithTag("Snack");
        if (_snack)
        {
            EnemyRespawn();
            RotateA();
        }
    }
    public void EnemyRespawn()
    {
        _time += Time.deltaTime;
        if(_time > _cooltime)
        {
            Instantiate(_enemy, this.transform.position, transform.rotation);
            _time = 0;
        }
    }
    public void RotateA()
    {
        _target = _snack.transform.position;
        transform.RotateAround(_target, Vector3.forward, 30 * Time.deltaTime);
    }
}
