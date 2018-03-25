using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour {

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        Debug.Log("Button click!");
        // キャラのプレファブを取得
        GameObject charaTest = (GameObject)Resources.Load("Prefabs/animeTest");

        // キャラ開始ポジションを設定
        Vector3 position = new Vector3(-440, -560, 480);

        // プレファブからインスタンス生成
        Instantiate(charaTest, position, Quaternion.identity);
    }
}
