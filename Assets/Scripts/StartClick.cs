using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    

    //�X�^�[�g���j���[�Ŏg�������Ԃ�ۑ�����֐���錾
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
