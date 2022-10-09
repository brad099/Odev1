using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float Speed;

    void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }
}
