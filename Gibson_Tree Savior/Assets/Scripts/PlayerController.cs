using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake; 
public class PlayerController : MonoBehaviour {
    public GameObject player;
    public Vector3 RotationLeftValue;
    public Vector3 RotationRightValue;
    public Image HP1;
    public Image HP2;
    public Image HP3;
    public float Total;
    public float Tick;
    public CameraShake cameraShake;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Tick >= 1)
        {
            HP1.enabled = false;
        }
        if (Tick >= 2)
        {
            HP2.enabled = false;
        }
        if (Tick >= 3)
        {
            HP3.enabled = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(RotationLeftValue * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(RotationRightValue * Time.deltaTime);

        }

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Branch"))
        {
            Debug.Log("LostALife");
            Tick = Tick + 1;
            StartCoroutine(cameraShake.Shake(.15f, .4f));
        }
            
    }
}
