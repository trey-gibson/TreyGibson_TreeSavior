using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
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
        if (TargetRotation == CameraPosition2.transform.rotation)
        {
            //TargetRotateObject.transform.position = CameraPosition2.transform.position;
            TargetRotateObject.transform.rotation = Quaternion.Slerp(TargetRotateObject.transform.rotation, Quaternion.Euler(BackSideRotation), TurnSpeed * Time.deltaTime);
        }

        if (TargetRotation == CameraPosition1.transform.rotation)
        {
            //TargetRotateObject.transform.position = CameraPosition1.transform.position;
            TargetRotateObject.transform.rotation = Quaternion.Slerp(TargetRotateObject.transform.rotation, Quaternion.Euler(FrontSideRotation), TurnSpeed * Time.deltaTime);
        }
    }
}