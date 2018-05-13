using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerRightManager : MonoBehaviour {

    public double towerRightHP;
    public RightTowerHP rightTowerHP;
    private HpManager hpManager;
    private GameObject towerRight;

    // Use this for initialization
    void Start () {

        towerRightHP = 1000;
        towerRight = GameObject.Find("TowerRight");
        hpManager = GetComponent<HpManager>();
            
    }
	
	// Update is called once per frame
	void Update () {

        rightTowerHP.GetComponent<RightTowerHP>().rightTowerHP = towerRightHP;

        if(towerRightHP <= 0)
        {
            
            hpManager.DestroyCheck(towerRight);
            
        }

    }

    public void Damage(double damage)
    {
        towerRightHP = towerRightHP - damage;
    }
}
