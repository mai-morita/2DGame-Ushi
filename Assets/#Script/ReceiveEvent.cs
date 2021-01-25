using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンの切り替えに必要

//ボタンを押すとシーンが切り替わるスクリプト

public class ReceiveEvent : MonoBehaviour {

    public string sceneName;

    public void MyPointerDownUI() {
        SceneManager.LoadScene (sceneName);
    }
    //クリックしたらシーンを切り替える
}
