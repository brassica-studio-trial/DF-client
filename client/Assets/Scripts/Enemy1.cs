using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    const double attack = 20;

    private bool flg_attack = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(-0.5f, 0, 0);
    }

    void OnTriggerStay(Collider other)
    {
        GameObject enemyObj;
        enemyObj = null;

        // 衝突相手が敵
        if (other.gameObject.tag == "Player")
        {
            enemyObj = other.gameObject;
            flg_attack = true;
        }

        if (enemyObj == null)
        {
            return;
        }

        if (enemyObj.name == "animeTest")
        {

            TowerRightManager towerRight = enemyObj.GetComponent<TowerRightManager>();
            towerRight.Damage(attack);
        }
    }
}
