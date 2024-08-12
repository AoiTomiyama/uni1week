using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReflect : MonoBehaviour
{
    [SerializeField] GameObject _reflectShield;
    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0);
        transform.up = mousePos - transform.position;
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_reflectShield, transform.up, transform.rotation);
        }
    }
}
