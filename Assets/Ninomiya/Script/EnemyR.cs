using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyR : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    [SerializeField] float _cooltime;
    float _time;
    [SerializeField] Vector3 _target;

    GameObject _snackgo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _snackgo = GameObject.FindGameObjectWithTag("Snack");
        if (_snackgo)
        {
            EnemyRespawn();
            RotateA();
        }
    }
    public void EnemyRespawn()
    {
        _time += Time.deltaTime;
        if (_time > _cooltime && _snackgo)
        {
            Instantiate(_enemy, this.transform.position, transform.rotation);
            _time = 0;
        }
    }
    public void RotateA()
    {
        _target = _snackgo.transform.position;
        transform.RotateAround(_target, Vector3.forward, 30 * Time.deltaTime);
    }
}
