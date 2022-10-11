using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int _EnemyHealth;

    public void Damage(int _damageAmount) 
    {
        _EnemyHealth -= _damageAmount;

        if (_EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


}
