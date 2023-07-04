using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    //開始画面からストリートシーンに来たかを判別する関数を宣言。
    public static bool FirstStreet;

    //スタートメニューで使った時間を保存する関数を宣言
    public static float StartMenuTime = 0;

    public void OnclickStart()
    {
        ChangeScene();

        FirstStreet = true;


    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Street");
    }
}
