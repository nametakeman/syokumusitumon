using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMoving : MonoBehaviour
{


    // フレーム更新ごとに呼び出される関数
    void Update()
    {
        /*Transformはオブジェクトの位置、回転、スケールを格納するクラス
        　親子関係を持たせることができる
        thisでは自身のオブジェクトを指定する。
        以下は省略形ちゃんと書くと
        this.gameObject.GetComponent<Transform> ();となる
        */
        Transform myTransform = this.transform;

        /*
        Vector3は3dの座標を持つ構造体。以下ではVector3としての変数をposとして宣言している。
        */
        Vector3 pos = myTransform.position;
        
        //以下ではオブジェクトのx座標が14を超えるまで毎フレームx座標を0.01追加していく
        if(pos.x > 14){
            return;
        }

        pos.x += 0.01f;
        

        myTransform.position = pos; 

      
    }
}
