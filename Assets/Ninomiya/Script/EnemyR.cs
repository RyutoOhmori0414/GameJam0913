using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyR : MonoBehaviour
{
    [SerializeField] GameObject _enemy;
    [SerializeField] float _cooltime;
    float _time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyRespawn();
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
}
