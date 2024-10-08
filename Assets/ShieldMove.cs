using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShieldMove : MonoBehaviour
{
    [SerializeField, Header("移動速度")] float _speed;
    [SerializeField, Header("持続時間")] float _duration;
    Rigidbody2D _rb;
    void Start()
    {
        GetComponent<SpriteRenderer>().DOFade(0, _duration).OnComplete(() => Destroy(gameObject));
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up * _speed, ForceMode2D.Impulse);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
