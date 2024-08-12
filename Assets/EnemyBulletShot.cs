using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletShot : MonoBehaviour
{
    [SerializeField, Header("発射インターバル")] float _interval;
    [SerializeField, Header("弾の種類")] List<GameObject> _bullets = new();
    [SerializeField, Header("ターゲット")] Transform _target;
    float _time;
    void Update()
    {
        if (_time < _interval)
        {
            _time += Time.deltaTime;
        }
        else
        {
            Shoot();
            _time = 0;
        }
        if (_target != null)
        {
            transform.up = _target.position - transform.position;
        }
    }
    void Shoot()
    {
        Instantiate(_bullets[Random.Range(0, _bullets.Count)], transform.position, transform.rotation);
    }
}
