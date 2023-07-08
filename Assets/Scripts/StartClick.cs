using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    

    //スタートメニューで使った時間を保存する関数を宣言
    public static float StartMenuTime;

    public static float Score;

    public void OnclickStart()
    {
        StartMenuTime = Mathf.Floor(Time.time);

        Score = 0;

        ChangeScene();


    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Street");
    }
}
