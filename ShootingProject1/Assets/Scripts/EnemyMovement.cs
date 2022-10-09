using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField]int _EnemyHealth;
    [SerializeField]float _EnemySpeed;
    GameObject Body;
    [SerializeField] Color BodyColor;
    GameObject Eye;
    [SerializeField] Color EyeColor;
    GameObject LeftArm;
    [SerializeField] Color LeftAramColor;
    GameObject RightArm;
    [SerializeField] Color RightArmColor;
    private GameObject _PlayerHero;
    private CharacterController _char;


    void Start()
    {
        _char = GetComponent<CharacterController>();
        _PlayerHero = GameObject.FindGameObjectWithTag("Player");
        Body = gameObject;
        Coloring(Body, BodyColor);
        Eye = transform.GetChild(0).gameObject;
        Coloring(Eye, EyeColor);
        LeftArm = transform.GetChild(1).gameObject;
        Coloring(LeftArm, LeftAramColor);
        RightArm = transform.GetChild(2).gameObject;
        Coloring(RightArm, RightArmColor);
    }
    void Coloring(GameObject go, Color colors)
    {
        go.GetComponent<Renderer>().material.color = colors;
    }

    private void FixedUpdate()
    {
        Vector3 _MovingForward = transform.forward * _EnemySpeed;
        transform.LookAt(_PlayerHero.transform.position);
        _char.Move(_MovingForward * _EnemySpeed * Time.deltaTime);  
    }

    public void OnTriggerEnter(Collider _colliding)
    {
        if (_colliding.gameObject.CompareTag("Player"))
        {
            _colliding.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }

}
