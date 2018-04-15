using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    private double pastTime;
    private GameObject EnemyChara;
    private GameObject TowerRight;

    // Use this for initialization
    void Start () {
        // 経過時間変数の初期化
        pastTime = 0;
        
        // 敵キャラのプレファブを取得
        // フォルダの中の敵キャラから配列取得させる
        EnemyChara = (GameObject)Resources.Load("Prefabs/Enemies/enemy1");

        // 生成先のオブジェクトを取得
        TowerRight = GameObject.Find("TowerRight");


    }
	
	// Update is called once per frame
	void Update () {
        pastTime++;


        if ( pastTime == 1000)
        {
            // キャラ開始ポジションを設定
            Vector3 position = TowerRight.transform.position;

            // プレファブからインスタンス生成
            //GameObjectのTowerLeftの子として生成
            Instantiate(EnemyChara, position, Quaternion.identity, TowerRight.transform);
        }

	}
}
