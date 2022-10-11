using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _BulletSpeed;
    [SerializeField] int _amount;
    private Rigidbody2D _rb;
    void Start()
    {
        Rigidbody2D _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = transform.right * _BulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")) 
        {
            Enemy Enemy = other.gameObject.GetComponent<Enemy>();
            if (Enemy != null) 
            {
                Enemy.Damage(_amount);
            }
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
