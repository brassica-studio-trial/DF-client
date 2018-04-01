using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        Debug.Log("Button click!");
        // キャラのプレファブを取得
        GameObject charaTest = (GameObject)Resources.Load("Prefabs/enemy1");

        // 生成先のオブジェクトを取得
        GameObject TowerLeft = GameObject.Find("TowerLeft");

        // キャラ開始ポジションを設定
        Vector3 position = new Vector3(-440, -520, 480);

        // プレファブからインスタンス生成
        //GameObjectのTowerLeftの子として生成
        Instantiate(charaTest, position, Quaternion.identity, TowerLeft.transform);
    }
}
