using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSnapperCollision : MonoBehaviour {
    public GameObject TargetRotateObject;
    public Transform CameraPosition1;
    public Transform CameraPosition2;

    public Vector3 FrontSideRotation;
    public Vector3 BackSideRotation;

    public bool IsFront = true;
    // Transforms to act as start and end markers for the journey.

    public Quaternion TargetRotation;
    public float TurnSpeed;
    // Movement speed in units/sec.
    public float speed = 1.0F;
    
    // Total distance between the markers.
    private float journeyLength; 
    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
        
    }
void OnTriggerEnter(Collider other)
{
    if (IsFront == true)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I was hit!");
            //MainCamera.transform.position = CameraPosition2.transform.position;
            //MainCamera.transform.rotation = CameraPosition2.transform.rotation;
            TargetRotation = CameraPosition2.transform.rotation;
            IsFront = false;
        }
    }
    else
    if (IsFront == false)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I was hit!");
            TargetRotation = CameraPosition1.transform.rotation;
            IsFront = true;
        }
    }
}
    


