using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyR : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    [SerializeField] float _cooltime;
    float _time;
    [SerializeField] Vector3 _target;

    bool _move = false;

    GameObject _snack;
    // Start is called before the first frame update

    private void OnEnable()
    {
        GameManager.GameStart += EnemyStart;
    }
    void Start()
    {
        _move = false;
    }

    // Update is called once per frame
    void Update()
    {
        _snack = GameObject.FindGameObjectWithTag("Snack");
        if (_snack && _move)
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

    void EnemyStart ()
    {
        _move = true;
    }
    public void RotateA()
    {
        _target = _snack.transform.position;
        transform.RotateAround(_target, Vector3.forward, 30 * Time.deltaTime);
    }

    private void OnDisable()
    {
        GameManager.GameStart -= EnemyStart;
    }
}
