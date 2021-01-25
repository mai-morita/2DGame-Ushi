using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//キーを押したら移動＆ジャンプするスクリプト

public class MoveJumpOnKeyPress : MonoBehaviour {

    public float speed = 3;
    public float jumppower = 8;
    //スピードとジャンプ力を指定

    bool pushFlag = false;
    bool jumpFlag = false;
    bool groundFlag = false;
    Rigidbody2D rbody;

    //左向きか、押しっぱなしか、ジャンプ中かを判断

    void Start() {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    //最初に、衝突時に回転させないようにする

    void Update() {
        if(Input.GetKey("space") && groundFlag) {　//もし、スペースキーが押された時、足が何かに触れていたら
            if(pushFlag == false) {　//押しっぱなしじゃなければ
                jumpFlag = true;　　　//ジャンプの準備
                pushFlag = true;　　　//押しっぱなしの状態に
            }
        }else {
            pushFlag = false; 　//押しっぱなしを解除する
        }
    }

    void FixedUpdate() {
        this.transform.Translate(speed/50, 0, 0);
        if(jumpFlag) {
            jumpFlag = false;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
    //重力をつけたまま移動する

    void OnTriggerStay2D(Collider2D collision) {
        groundFlag = true;
    }
    //足が何かに触れたら実行

    void OnTriggerExit2D(Collider2D collision) {
        groundFlag = false;
    }
    //足に何も触れていなかったら実行しない
}
