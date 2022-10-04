using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubeman : MonoBehaviour
{
    public string playerName;
    public float speed = 5f;
    public int health = 100;
    public Vector3 location = new Vector3(0,0,0);
    public Sphereman spherescript;
    public GameObject sph;


    void Start()
    {
        Debug.Log("Name : " + spherescript.PlayerName);
        Debug.Log("Speed is : " + spherescript.speed);
        Debug.Log("Health : " + spherescript.health);
        Debug.Log("Your current Location : " + spherescript.location2);
    }



    void Update()
    {
        sph.GetComponent<Renderer>().material.color = Color.green;
    }
}
