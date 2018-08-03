using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDestroy : MonoBehaviour
{
	// Use this for initialization

    
        public float DestroyDelay;

        void Start()
        {
            Invoke("DestroyThis", DestroyDelay);
        
        }
        
      void DestroyThis()
        {
            Destroy(gameObject);
        }
    }

