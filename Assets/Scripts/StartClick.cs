using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    //�J�n��ʂ���X�g���[�g�V�[���ɗ������𔻕ʂ���֐���錾�B
    public static bool FirstStreet;

    //�X�^�[�g���j���[�Ŏg�������Ԃ�ۑ�����֐���錾
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
