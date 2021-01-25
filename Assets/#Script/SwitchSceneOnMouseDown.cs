using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンの切り替えに必要

//ボタンを押すとシーンが切り替わるスクリプト

public class SwitchSceneOnMouseDown : MonoBehaviour {

    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == targetObjectName) {
            SceneManager.LoadScene (sceneName);
        }
    }
}
