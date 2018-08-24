using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int time;
    public float score;
    public int boop;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        score += Time.deltaTime*2;
     

        /*{
            if (score > 1f)
                boop += 10;
        }*/

            //float translation = Time.deltaTime * 5;
        scoreText.text = score. ToString("0");
	}
}
