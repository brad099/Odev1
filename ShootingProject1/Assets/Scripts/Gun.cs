using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]GameObject _Bullet;
    [SerializeField]GameObject _SpawnPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 
        Instantiate( _Bullet,_SpawnPoint.transform.position,transform.rotation);
        }
    }

}
