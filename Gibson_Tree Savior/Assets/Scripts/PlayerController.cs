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
    public bool Dead;
    public float Total;
    public float Tick;
    public CameraShake cameraShake;
    public Text scoreText,finalText;
    public Texture HitYou;
    public bool DisplayHitYou = false;
    public RawImage HitYouRef;
    public float Delay;
    Color HitYouAlphaREF;
    bool doOnce,doOnce2,doOnce3;
    // Use this for initialization
    void Start () {
        HitYouRef.enabled = false;
        finalText.enabled = false;
	}
    void Update () {
        //HitYouRef.color = HitYouAlphaREF;

        if (HP1.enabled == false&& doOnce == false)
        {
            StartCoroutine(HealthDelay());
            doOnce = true;
        }

        if (HP2.enabled == false && doOnce2 == false)
        {
            StartCoroutine(HealthDelay());
            doOnce2 = true;
        }

        if (HP3.enabled == false && doOnce3 == false)
        {
            StartCoroutine(HealthDelay());
            doOnce3 = true;
        }


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
            {
                if (HP3.enabled == false)
                {
                    scoreText.fontSize = 150;
                    scoreText.rectTransform.position = new Vector3(150.5f, 360f, 0f);
                    Dead = true;
                    finalText.enabled = true;
                }
                
            }
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




    IEnumerator HealthDelay()
    {
        HitYouRef.enabled = true;
        yield return new  WaitForSecondsRealtime(Delay);
        HitYouRef.enabled = false;
        StopAllCoroutines();


    }
}
