using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//カウンター

public class ShowCounterForever : MonoBehaviour {

    void Update() {
        GetComponent<Text>().text = Counter.value.ToString();
    }
    //UIテキストの文字列を変更する(＝)変数に入った数値を文字列に変換する
    
}