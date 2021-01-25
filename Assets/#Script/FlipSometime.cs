using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//時々反転するスクリプト

public class FlipSometime : MonoBehaviour {

    public int maxCount = 50;
    int count = 0;
    bool flipFlag = false;

    void Start() {
        count = 0;
    }
    //カウントをリセット

    void FixedUpdate() {
        count = count + 1;
        if(count == maxCount) {
            this.transform.Rotate(0, 0, 180);
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
   //SpriteRenderer=スプライトを表示するコンポーネント
}
