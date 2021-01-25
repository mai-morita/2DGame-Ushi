using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステージプレハブをランダム生成するスクリプト

public class StagePrefabList : MonoBehaviour {

    public GameObject[] Train;
    public GameObject firstStage;
    public GameObject GoalStage;

    void Start() {
        if(firstStage) {
            GameObject frameObject = firstStage.transform.Find("frame").gameObject;
            float width = frameObject.GetComponent<SpriteRenderer>().bounds.size.x;
            GameObject frontStage = firstStage;
                
            for(int i = 0; i<10; i++) {
                Vector3 nextVector = frontStage.transform.position + new Vector3(width, 0, 0);
                int number = Random.Range(0, Train.Length); 

                if(i == 9) {
                    frontStage = Instantiate(GoalStage, nextVector, frontStage.transform.rotation);
                } else {
                    frontStage = Instantiate(Train[number], nextVector, frontStage.transform.rotation);
                }
            }
        }
    }
    //乱数を作成するメソッド(0からTrain配列の要素数までの間の整数値から)
    //Train配列のnumber番目が指定され、Instantiateで生成。
    //生成する(コピーしたい既存オブジェクト、新規オブジェクトの位置、新規オブジェクトの向き)
}