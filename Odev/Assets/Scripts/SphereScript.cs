using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    [SerializeField]
    private string _playerName = "SpherePlayer";
    [SerializeField]
    private float _health = 100f;
    [SerializeField]
    private float _speed = 20f;
    [SerializeField]
    private Vector3 _location = Vector3.zero;

    private CubeScript _cubeScript;
    private Renderer _manageColor;

    void Start()
    {
        _cubeScript = FindObjectOfType<CubeScript>();
        _manageColor = _cubeScript.GetComponent<Renderer>();
        _manageColor.material.color = Color.cyan;

        Debug.Log(_cubeScript);
    }

    public override string ToString()
    {
        return $"\nPlayer name : {_playerName}\n" +
               $"Player Health : {_health}\n" +
               $"Player Speed : {_speed}\n" +
               $"Player Location : x - {_location.x}; y - {_location.y}; z - {_location.z};";
    }
}
