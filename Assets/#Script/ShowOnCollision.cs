using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//衝突時見えるようにするスクリプト

public class ShowOnCollision : MonoBehaviour {

    public string targetObjectName01;
    public string targetObjectName02;
    public string showObjectName;
    GameObject showObject;

    void Start() {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == targetObjectName01) {
            Debug.Log("go-ru1");
            showObject.SetActive(true);
        } 
        if(collision.gameObject.name == targetObjectName02) {
            Debug.Log("go-ru2");
            showObject.SetActive(true);
        } 

    }
}
