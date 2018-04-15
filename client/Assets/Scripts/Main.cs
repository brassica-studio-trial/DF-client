using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    const double attack = 10;

    private bool flg_attack = false;

    // Use this for initialization
    void Start () {
    
    }

	// Update is called once per frame
	void Update () {
        if (!flg_attack)
        {
            this.gameObject.transform.Translate(0.8f, 0, 0);
        }
        else
        {
            return;
        }
    }

    void OnTriggerStay(Collider other)
    {
        GameObject enemyObj;
        enemyObj = null;

        // 衝突相手が敵
        if (other.gameObject.tag == "Enemy")
        {
            enemyObj = other.gameObject;
            flg_attack = true;
        }

        if (enemyObj == null)
        {
            return;
        }

        if (enemyObj.name == "TowerRight")
        {
            
            TowerRightManager towerRight = enemyObj.GetComponent<TowerRightManager>();
            towerRight.Damage(attack);
        }
    }

}
