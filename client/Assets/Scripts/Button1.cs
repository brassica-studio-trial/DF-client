﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour {

    public TowerLeftManager towerLeft;
    const double button1EnergyCost = 100;

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        Debug.Log("Button click!");

        //TowerLeftのchargedEnergiesからbutton1EnergyCostを引く
        towerLeft.GetComponent<TowerLeftManager>().chargedEnergies -= button1EnergyCost;


       // キャラのプレファブを取得
        GameObject charaTest = (GameObject)Resources.Load("Prefabs/animeTest");

        // 生成先のオブジェクトを取得
        GameObject TowerLeft = GameObject.Find("TowerLeft");

        // キャラ開始ポジションを設定
        Vector3 position = new Vector3(-440, -560, 480);

        // プレファブからインスタンス生成
        //GameObjectのTowerLeftの子として生成
        Instantiate(charaTest, position, Quaternion.identity, TowerLeft.transform);
    }
}
