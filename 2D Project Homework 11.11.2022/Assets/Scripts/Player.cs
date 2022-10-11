using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Player : MonoBehaviour
{
    [SerializeField] float _Speed;
    [SerializeField] Transform _ShootPos;
    [SerializeField] GameObject _Bullet;
    private float _Move;
    private Rigidbody2D _Rb;
    private bool _FacingRight = true;

    private void Start()
    {
            _Rb = GetComponent<Rigidbody2D>();
    }

        private void Update()
    {
        _Move = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(_Move * _Speed, 0, 0) * Time.deltaTime;

        if (_Move > 0 && !_FacingRight)
        {
            Flip();
        }
        else if (_Move < 0 && _FacingRight)
        {
            Flip();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire(); 
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    private void Flip()
    {
        _FacingRight = !_FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    private void Fire() 
    {
        Instantiate(_Bullet, _ShootPos.position, _ShootPos.rotation);
    } 
}
