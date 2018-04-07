using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    const double attack = 10;

    private TowerRight towerRight;

    // Use this for initialization
    void Start () {
    
    }

	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(0.8f, 0, 0);

    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject enemyObj;
        enemyObj = null;

        // 衝突相手が敵
        if (other.gameObject.tag == "Enemy")
        {
            enemyObj = other.gameObject;
        }

        if (enemyObj == null)
        {
            return;
        }

        if (enemyObj.name == "TowerRight")
        {
            towerRight.Damage(attack);
        }
    }

}
