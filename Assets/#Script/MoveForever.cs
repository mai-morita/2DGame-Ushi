using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ずっと右に動くスクリプト

public class MoveForever : MonoBehaviour {

    public float speed = 3;

    void FixedUpdate() {
        this.transform.Translate(speed/50, 0, 0);
    }
}
