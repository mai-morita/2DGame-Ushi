using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使用可能にする

//フェードインとフェードアウトに関するスクリプト

public class FadeCanvas : MonoBehaviour {

    public bool fadeIn = false;
    public bool fadeOut = false;

    float fadeSpeed = 0.01f;//透明化の速さ
    float red, green, blue, alpha;//パネルの色、不透明度を管理するための変数
    Image fadeImage;  

    void Start() {
        fadeImage = GetComponent<Image> ();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alpha = fadeImage.color.a;
        fadeOut = true;
    }
    ////Panelの色を取得

    void Update () {
        if(fadeIn) {
            Debug.Log("1");
            FadeIn();
        }
        if (fadeOut) {
            Debug.Log("234");
            FadeOut();
        }
    }

    void FadeOut() {
        fadeImage.enabled = true;
        alpha += fadeSpeed;
        setAlpha();
        if(alpha >= 1) {
            fadeOut = false;
            fadeIn = true;
        }
    }
    //パネルの表示をオン
    //不透明度をあげていく
    //変更した透明度をパネルに反映
    //完全に不透明になったら処理を抜ける
    //フェードイン開始の指示を行う

    void FadeIn() {
        alpha -= fadeSpeed;
        setAlpha();
        if(alpha <= 0) {
            fadeIn = false;
            fadeImage.enabled = false;
        }
    }

    void setAlpha() {
       fadeImage.color = new Color(red, green, blue, alpha);
    }
}
//なんで上手いこといかなかつたのかわからないコードMEMO

    // GameObject currentFlag;

    // public void StartFadeIn(GameObject flag) {
    //     fadeOut = true;
    //     currentFlag = flag;
    // }
    //フェードインを開始させる
    //どのオブジェクトか知るために記憶する

    // void WarpOrder() {
    //     Warp warpOrder = currentFlag.GetComponent<Warp>();
    //     warpOrder.ExecWarp();
    // }
    //衝突したオブジェクトのWarpのExecWarpを参照

    // WarpOrder();
