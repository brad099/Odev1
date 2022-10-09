using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject Body;
    [SerializeField] Color BodyColor;

    GameObject Eye;
    [SerializeField] Color EyeColor;

    GameObject LeftArm;
    [SerializeField] Color LeftAramColor;

    GameObject RightArm;
    [SerializeField] Color RightArmColor;
    GameObject _Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Body = gameObject;
        ColorizeBodyPart(Body, BodyColor);
        Eye = transform.GetChild(0).gameObject;
        ColorizeBodyPart(Eye, EyeColor);
        LeftArm = transform.GetChild(1).gameObject;
        ColorizeBodyPart(LeftArm, LeftAramColor);
        RightArm = transform.GetChild(2).gameObject;
        ColorizeBodyPart(RightArm, RightArmColor);


        _Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void ColorizeBodyPart(GameObject go, Color c)
    {
        go.GetComponent<Renderer>().material.color = c;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector3.Distance(gameObject.transform.position, _Enemy.transform.position));

        if (Vector3.Distance(gameObject.transform.position,_Enemy.transform.position) <=5)
        {
            Debug.Log("Fire");
        }

        transform.LookAt(_Enemy.transform.position);
    }
}
