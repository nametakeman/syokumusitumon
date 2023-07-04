using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerS : MonoBehaviour
{
    // Start is called before the first frame update
    public static float Limmit;

    bool FirstStreet = StartClick.FirstStreet;

    float StartMenuTime = StartClick.StartMenuTime;

    public GameObject Timer_Object;

    

    void Start()
    {
     //初めてのストリートシーンであったときのみスタート画面で経過した時間を記録する
     if(FirstStreet == true)
        {
            StartMenuTime = Mathf.Floor(Time.time);
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        //Limmit関数にゲーム開始時からの秒数を取得してスタートメニューで経過した時間を引く。
        Limmit = Mathf.Floor(Time.time) - StartMenuTime;

        //Limmitをテキスト化する.
        string LimmitT = Limmit.ToString();

        //タイマーのコンポーネントを取得
        Text Timer_text = Timer_Object.GetComponent<Text>();

        //ここでタイマーのテキストを書き換え
        Timer_text.text = LimmitT;

    }

}
