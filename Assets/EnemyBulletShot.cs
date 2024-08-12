using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletShot : MonoBehaviour
{
    [SerializeField, Header("���˃C���^�[�o��")] float _interval;
    [SerializeField, Header("�e�̎��")] List<GameObject> _bullets = new();
    [SerializeField, Header("�^�[�Q�b�g")] Transform _target;
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
