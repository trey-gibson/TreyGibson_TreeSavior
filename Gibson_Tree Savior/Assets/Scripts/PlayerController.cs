using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject player;
    public Vector3 RotationLeftValue;
    public Vector3 RotationRightValue;
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(RotationLeftValue * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(RotationRightValue * Time.deltaTime);

        }

    }
}
