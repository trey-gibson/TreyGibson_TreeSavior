using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchCollision : MonoBehaviour {
   
    // Use this for initialization

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Branch")
            {
            Debug.Log("LostALife");
        }
    }

}