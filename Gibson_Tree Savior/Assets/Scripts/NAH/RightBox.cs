using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBox : MonoBehaviour
{
    public Transform TargetRotationTransform;
    public bool IsRight = true, IsLeft = false;
    // Transforms to act as start and end markers for the journey.

    public Vector3 TargetEulerRotation;
    public float TurnSpeed;
    // Movement speed in units/sec.
    public float speed = 1.0F;

    // Total distance between the markers.
    private float journeyLength;
    // Use this for initialization
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //TargetRotationTransform.rotation = Quaternion.Slerp(TargetRotationTransform.rotation, Quaternion.Euler(TargetEulerRotation), TurnSpeed * Time.deltaTime);

        TargetRotationTransform.rotation = Quaternion.RotateTowards(TargetRotationTransform.rotation, Quaternion.Euler(TargetEulerRotation), TurnSpeed * Time.deltaTime);


    }
    void OnTriggerEnter(Collider other)
    {
        if (IsRight == true && IsLeft == false)
        {
            if (other.tag == "Player")
            {
                Debug.Log("I was hit!");
                //MainCamera.transform.position = CameraPosition2.transform.position;
                //MainCamera.transform.rotation = CameraPosition2.transform.rotation;
                TargetEulerRotation = new Vector3(transform.rotation.eulerAngles.x, 180, transform.rotation.eulerAngles.z);
                IsRight = false;
                IsLeft = true;
            }

        }
        else
        if (IsRight == false && IsLeft == true)
        {
            if (other.tag == "Player")
            {
                Debug.Log("I was hit!");
                //MainCamera.transform.position = CameraPosition2.transform.position;
                //MainCamera.transform.rotation = CameraPosition2.transform.rotation;
                //StartCoroutine(CameraPivotDelay());
                TargetEulerRotation = new Vector3(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);


                IsRight = true;
                IsLeft = false;
                Debug.Log("1");
            }
        }
    }
}