using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//衝突時に消すスクリプト

public class HideOnCollision : MonoBehaviour {

    public string targetObjectName;

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == targetObjectName) {
            gameObject.SetActive(false);
        }
    }
}
