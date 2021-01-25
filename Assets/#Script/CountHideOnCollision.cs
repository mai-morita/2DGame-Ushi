using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//カウンターにスコアを追加

public class CountHideOnCollision : MonoBehaviour {

    public string targetObjectName;
    public int addValue = 50;

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == targetObjectName) {
            Counter.value = Counter.value + addValue;
            this.gameObject.SetActive(false);
        }
    }
    //衝突したものとターゲットが一緒の時、カウンターにスコアを追加で入れる
}
