using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
    [SerializeField] Vector3 Rotation;
    [SerializeField] bool isWorld = false;
    [SerializeField] bool Stop = false;

    [SerializeField] Vector3 Turning;
    [SerializeField] bool fun = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Stop)
        {
            if (!isWorld)
            {
                transform.localRotation = Quaternion.Euler(Rotation);
            }
            else
            {
                transform.rotation = Quaternion.Euler(Rotation);
            }
        }
    }
}
