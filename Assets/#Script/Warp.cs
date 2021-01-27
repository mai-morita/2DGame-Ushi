using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ワープさせるためのスクリプト

public class Warp : MonoBehaviour {

    public Vector2 warpPoint;
    private Vector3 warpTarget;
    
    void OnCollisionEnter2D(Collision2D collision) {
        warpTarget = gameObject.transform.position;
        warpTarget.x = warpPoint.x;
        warpTarget.y = warpPoint.y;
        gameObject.transform.position = warpTarget;
    }
    //ターゲットから指定したポイント(x,y)に移動させる。
}

//なんで上手いこといかなかつたのかわからないコードMEMO
    
    // public GameObject fadePanelObj;

    // void OnCollisionEnter2D(Collision2D collision) {
    //     FadeCanvas fadePanel = fadePanelObj.GetComponent<FadeCanvas>();
    //     fadePanel.StartFadeIn(this.gameObject);
    // }
    // 衝突時、別のオブジェクトのスクリプトを参照する場合
    //FadeCanvasのStartFadeInを参照し、self =を渡す。

