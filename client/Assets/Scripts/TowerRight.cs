using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerRight : MonoBehaviour {

    public double towerRightHP;
    public RightTowerHP rightTowerHP;
    
	// Use this for initialization
	void Start () {

        towerRightHP = 1000;

    }
	
	// Update is called once per frame
	void Update () {

        rightTowerHP.GetComponent<RightTowerHP>().rightTowerHP = towerRightHP;

    }

    public void Damage(double damage)
    {
        towerRightHP = towerRightHP - damage;
    }
}
