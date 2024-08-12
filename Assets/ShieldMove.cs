using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMove : MonoBehaviour
{
    [SerializeField, Header("�ړ����x")] float _speed;
    [SerializeField, Header("��������")] float _duration;
    void Start()
    {
        GetComponent<SpriteRenderer>().DOFade(0, _duration);
        transform.DOMove(transform.up * _speed, _duration).
            OnComplete(() => Destroy(gameObject));
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
