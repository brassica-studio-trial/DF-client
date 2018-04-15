using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public bool DestroyCheck ( GameObject gameObject)
    {
        if (gameObject == null)
        {
            return false;
        }
        else
        {
            Destroy(gameObject);
            return true;
        }
    }
}
