using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoving : MonoBehaviour
{
    //キャラクターの移動速度
    public float CharacterSpeed;


    // フレーム更新ごとに呼び出される関数
    void Update()
    {
        //ゲームのfpsを固定
        Application.targetFrameRate = 60;

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
        Vector3 Characterpos = myTransform.position;
        
        //以下ではオブジェクトのx座標が14を超えるまで毎フレームx座標をCharacterSpeed追加していく
        //もし14を超えていたら削除する。
        if(Characterpos.x > 14){
            Destroy (this.gameObject);
            return;
        }

        Characterpos.x += CharacterSpeed;
        

        myTransform.position = Characterpos; 

      
    }
}
