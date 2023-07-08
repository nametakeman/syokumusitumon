using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerS : MonoBehaviour
{

    //��������(�b)
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


        //Limmit�֐��ɃQ�[���J�n������̕b�����擾���ăX�^�[�g���j���[�Ōo�߂������Ԃ������B
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

     

        //Limmit���e�L�X�g������.
        LimmitMT = LimmitM.ToString("00");

        LimmitST = LimmitS.ToString("00");

        //�^�C�}�[�̃R���|�[�l���g���擾
        Text Timer_text = Timer_Object.GetComponent<Text>();

        //�����Ń^�C�}�[�̃e�L�X�g����������
        Timer_text.text = LimmitMT + ":" + LimmitST;

    }

    void ChangeScene()
    {
        SceneManager.LoadScene("End");
    }

}
