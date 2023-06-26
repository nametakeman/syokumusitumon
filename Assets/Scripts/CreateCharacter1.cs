using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter1 : MonoBehaviour
{
    //プレハブ格納用
    public GameObject Character1Prefab;

    //出現させる時間の計算タイマー
    public float CreateCharacterTimer;

    //出現させる間隔(秒)
    public float CreateCharacterInterval;

    void Start() {
        //一番初めのキャラクターを生成する
        Vector3 pos = new Vector3(-11.45f, 0.11f);

        Instantiate(Character1Prefab, pos, Quaternion.identity);
    }

    void Update(){
        
        //生成間隔を管理するタイマーを更新する
        CreateCharacterTimer += Time.deltaTime;

        //生成タイミングじゃないときはここで処理を終了
        if ( CreateCharacterTimer < CreateCharacterInterval ) return;

        //生成間隔を管理するタイマーをリセット
        CreateCharacterTimer = 0;

        // 座標(x,y)=(-11.45,0.11)に生成

        //生成位置
       Vector3 pos = new Vector3(-11.45f, 0.11f);

       //プレハブを指定位置に生成。Instantiateはオブジェクト生成用の関数
       //引数として(クローン元オブジェクト,座標,回転)になっている。
       Instantiate(Character1Prefab, pos, Quaternion.identity);
        
    }    
}
