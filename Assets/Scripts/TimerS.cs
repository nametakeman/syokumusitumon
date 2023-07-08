using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerS : MonoBehaviour
{

    //制限時間(秒)
    public static float LimmitTime = 60;

    float StartMenuTime = StartClick.StartMenuTime;

    public GameObject Timer_Object;


    

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float Limmit;
        float LimmitS;
        float LimmitM;
        string LimmitMT;
        string LimmitST;


        //Limmit関数にゲーム開始時からの秒数を取得してスタートメニューで経過した時間を引く。
        Limmit = LimmitTime - ( Mathf.Floor(Time.time) - StartMenuTime );

        if (Limmit <= 0)
        {
            ChangeScene();
            return;
        }

        if (Limmit >= 60)
        {
            LimmitM = Limmit / 60;
            LimmitS = Limmit - 60 * LimmitM;
        }
        else
        {
            LimmitM = 0;
            LimmitS = Limmit;
        }

     

        //Limmitをテキスト化する.
        LimmitMT = LimmitM.ToString("00");

        LimmitST = LimmitS.ToString("00");

        //タイマーのコンポーネントを取得
        Text Timer_text = Timer_Object.GetComponent<Text>();

        //ここでタイマーのテキストを書き換え
        Timer_text.text = LimmitMT + ":" + LimmitST;

    }

    void ChangeScene()
    {
        SceneManager.LoadScene("End");
    }

}
