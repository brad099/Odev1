using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] Vector3 Position;
    [SerializeField] Vector3 Rotation;
    [SerializeField] Vector3 Scale;
    [SerializeField] List<Transform> ChildsTransform;
    [SerializeField] Vector3 nextpos;
    [SerializeField] GameObject FirstChild;
    [SerializeField] bool SwitchWorld;
    [SerializeField] bool Stop = true;
    [SerializeField] Child c;

    void Start()
    {
        Debug.Log(gameObject.transform.position);
        // Aynı
        Debug.Log(transform.position);

        //transform.position = new Vector3(2, 2, 2);
        Debug.Log(transform.position);


        //gameObject.transform.localScale = new Vector3(2, 3, 1);
        // Aynı
        // transform.localScale = new Vector3(2, 3, 1);
        Debug.Log(transform.localScale);

        // Quaternion vs Euler Angels

        // gameObject.transform.rotation = Quaternion.Euler(30, 60, 90);
        //transform.rotation = Quaternion.Euler(30, 60, 90);
        // transform.rotation = Quaternion.EulerAngles();
        Debug.Log(transform.rotation);

        // ChildTransform = transform.GetChild(0);
        // Debug.Log(ChildTransform.name);
        // for (int i = 0; i < transform.childCount; i++)
        // {
        //     ChildsTransform.Add(transform.GetChild(i));
        // }

        // foreach (Transform item in transform)
        // {
        //     ChildsTransform.Add(item);
        // }

        FirstChild = transform.GetChild(0).gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = Position;
        // transform.rotation = Quaternion.Euler(Rotation);
        // transform.localScale = Scale;

        // FirstChild.transform.localPosition = Position;
        // Debug.Log(FirstChild.transform.localPosition + " | " + FirstChild.transform.position);
        FirstChild.GetComponent<Renderer>().material.color = Color.cyan;

        if (!Stop)
        {
            if (SwitchWorld)
                FirstChild.transform.rotation = Quaternion.Euler(Rotation);

            else
                FirstChild.transform.localRotation = Quaternion.Euler(Rotation);


            Debug.Log(transform.rotation.eulerAngles + " | " + transform.localRotation.eulerAngles);
        }
        //Debug.Log(transform.GetChild(2).GetChild(0).GetChild(2).GetChild(0).name);
        // c = transform.GetChild(2).GetChild(0).GetChild(2).GetChild(0).GetComponent<Child>();
        c = GetComponentInChildren<Child>();
        // GetComponentsInChildren<Child>();
        Debug.Log(GetComponentInChildren<Child>().name);
        
    }
}
