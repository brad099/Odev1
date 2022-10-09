using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyObject : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjectsList;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in gameObjectsList)
        {
            // if (go.tag == "Enemy")
            // {
            //     go.GetComponent<Renderer>().material.color = Color.red;
            // }
            // else if (go.tag == "Player")
            // {
            //     go.GetComponent<Renderer>().material.color = Color.blue;
            // }
            if (go.CompareTag("Enemy"))
            {
                go.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (go.CompareTag("Player"))
            {
                go.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
