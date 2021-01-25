using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    public Vector2 warpPoint;
    private Vector2 warpTarget;

    void OnCollisionEnter2D(Collision2D collision) {
        warpTarget = collision.gameObject.transform.position;
        warpTarget.x = warpPoint.x;
        warpTarget.y = warpPoint.y;
        collision.gameObject.transform.position = warpTarget;
    }
}