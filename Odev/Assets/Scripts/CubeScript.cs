using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class CubeScript : MonoBehaviour
{
    [SerializeField]
    private string _playerName = "CubePlayer";
    [SerializeField]
    private float _health = 100f;
    [SerializeField]
    private float _speed = 20f;
    [SerializeField]
    private Vector3 _location = Vector3.zero;

    private SphereScript _sphereScript;
    private Renderer _manageColor;
    [SerializeField] SphereScript[] GameObjectArray;
    [SerializeField] private List<SphereScript> GameObjectList;
    [SerializeField] private List<GameObject> GameObjectsListLoop;
     void Start()
    {
        _sphereScript = GameObject.FindObjectOfType<SphereScript>();
        _manageColor = _sphereScript.GetComponent<Renderer>(); //_manageColor = _sphereScript.gameObject.GetComponent<Renderer>(); Why works without gameObject?
        _manageColor.material.color = Color.green;

        Debug.Log(_sphereScript);  //_sphereScript.gameObject.ToString() Why Doesn't work?

        //GameObjectArray=GameObject.FindObjectsOfType<SphereScript>();
        //GameObjectList = GameObject.FindObjectsOfType<SphereScript>().ToList();

        //foreach (var item in GameObject.FindObjectsOfType<SphereScript>())
        //{
        //    GameObjectsListLoop.Add(item.gameObject);
        //}

    }

    public override string ToString()
    {
        return $"\nPlayer name : {_playerName}\n" +
               $"Player Health : {_health}\n" +
               $"Player Speed : {_speed}\n" +
               $"Player Location : x - {_location.x}; y - {_location.y}; z - {_location.z};";
    }

}
