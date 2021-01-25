using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//衝突時ゲームを止めるスクリプト

public class GameStopOnCollision : MonoBehaviour {

    public string targetObjectName;

    void Start() {
        Time.timeScale = 1;
        //時間を動かし動く状態
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == targetObjectName) {
            Time.timeScale = 0;  //時間を止め停止状態
        }
    }
}

