using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Material Transparent;
    


    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag.Equals("Branch"))
            {
            Debug.Log("im trans");
            transform.GetComponent<Renderer>().material = Transparent;
        }
    }
}