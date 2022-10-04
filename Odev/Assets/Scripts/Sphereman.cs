using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphereman : MonoBehaviour
{
    public string PlayerName;
    public float speed = 10f;
    public int health = 150;
    public Vector3 location2 = new Vector3(0,0,0);
    public GameObject cubecolor;
    public Cubeman cub;
    
    
    void Start()
    {
        Debug.Log("Name : " + cub.playerName);
        Debug.Log("Speed is : " + cub.speed);
        Debug.Log("Health : " + cub.health);
        Debug.Log("Your current Location : " + cub.location);
    }

    void Update()
    {
        cub.GetComponent<Renderer>().material.color = Color.blue;
    }
}
