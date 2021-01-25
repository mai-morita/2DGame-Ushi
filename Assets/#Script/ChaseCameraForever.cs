using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//水平にカメラがオブジェクトを追いかけるスクリプト

public class ChaseCameraForever : MonoBehaviour {

    Vector3 base_pos;

    void Start() {
        base_pos = Camera.main.gameObject.transform.position;
    }
    //最初に、カメラの元の位置を覚えておく

    void LateUpdate() {
        Vector3 pos = this.transform.position;
        pos.z = -10;　//カメラなので手前に移動
        pos.y = base_pos.y; 　//カメラの元の高さを使う
        pos.x = pos.x + 6;
        Camera.main.gameObject.transform.position = pos;
    }
}
