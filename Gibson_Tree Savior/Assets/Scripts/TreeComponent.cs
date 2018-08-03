using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeComponent : MonoBehaviour {

    [HideInInspector]public float MoveSpeed;
    [HideInInspector] public float RotationSpeed;

    // Use this for initialization
    void Start () {
        transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(90, -90), 0));
    }

    // Update is called once per frame
    void Update () {
        transform.position -= new Vector3(0,MoveSpeed,0) * Time.deltaTime;
	}

    //Rotate over time
    //transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y + RotationSpeed,0));

}
