using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] int _PlayerHealth;
    [SerializeField] float _PlayerSpeed;
    
    [SerializeField] GameObject _PlayerBody;
    [SerializeField] Color _PlayerBodyColor;

    [SerializeField] GameObject _PlayerEye;
    [SerializeField] Color _PlayerEyeColor;

    [SerializeField] GameObject _PlayerLeftHand;
    [SerializeField] Color _PlayerLeftHandColor;

    [SerializeField] GameObject _PlayerRightHand;
    [SerializeField] Color _PlayerRightHandColor;
    private CharacterController _Char;
    private void Start()
    {
        _Char = gameObject.GetComponent<CharacterController>();
        _PlayerBody.GetComponent<Renderer>().material.color = _PlayerBodyColor;
        _PlayerEye.GetComponent<Renderer>().material.color = _PlayerEyeColor;
        _PlayerLeftHand.GetComponent<Renderer>().material.color = _PlayerLeftHandColor;
        _PlayerRightHand.GetComponent<Renderer>().material.color = _PlayerRightHandColor;
    }

    private void FixedUpdate()
    {
        Vector3 _NextPos = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _Char.Move(_NextPos * _PlayerSpeed * Time.deltaTime);
         gameObject.transform.forward = _NextPos;

    }
} 
