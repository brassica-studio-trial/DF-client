using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerLeftManager : MonoBehaviour {

    private double m_energyChargeSpeeds;
    public double chargedEnergies;
    public EnergyScore energyScore;

	// Use this for initialization
	void Start () {

        m_energyChargeSpeeds = 1;
        
    }
	
	// Update is called once per frame
	void Update () {

        chargedEnergies += m_energyChargeSpeeds;
#if Debug
        Debug.Log(chargedEnergies);
#endif
        energyScore.GetComponent<EnergyScore>().energyScore = chargedEnergies;

            }

    public bool EnergyCost(double costEnergy)
    {
        if (chargedEnergies >= costEnergy)
        {
            chargedEnergies -= costEnergy;
            return true;
        }
        else
        {
            return false;
        }
    }
}
