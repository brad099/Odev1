using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]float _BulletSpeed;
    [SerializeField]float WaitTime;

    void Update()
    {
        transform.position += transform.forward * _BulletSpeed * Time.deltaTime;
        StartCoroutine(WaitingForDestroy(WaitTime));
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            StartCoroutine(WaitingForDestroy(WaitTime));

        }
        
    }


    IEnumerator WaitingForDestroy(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        Destroy(gameObject);
    }
}