using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BranchCollision : MonoBehaviour {

    public UnityEvent OnEnter;

    // Use this for initialization

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals ("Branch"))
            {
            Debug.Log("LostALife");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        OnEnter.Invoke();
        if (col.gameObject.tag.Equals("Branch"))
            Debug.Log("LostALife");
    }

}