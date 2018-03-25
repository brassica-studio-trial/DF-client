using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var parent = GameObject.Find("TowerLeft/animeTest(Clone)") as GameObject;

        if (parent != null)
        {
            // 子のTransformを取り出す
            var transforms = parent.GetComponentsInChildren<Transform>();


            float posX = transform.position.x;
            float posY = transform.position.y;
            float posZ = transform.position.z;
            posX++;
            transform.position.Set(posX, posY, posZ);

        }


    }
}
