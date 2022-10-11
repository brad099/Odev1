using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CameraFollow : MonoBehaviour
{
    private GameObject _PlayerPos;
    [SerializeField]Vector3 _Offset;
    [SerializeField]float Smooth;

    private void Start()
    {
        _PlayerPos = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        Vector3 _currPos = _PlayerPos.transform.position + _Offset;
        Vector3 _updPos = Vector3.Lerp(transform.position,_currPos,Smooth * Time.deltaTime);
        transform.position = _updPos;
    }   
}
