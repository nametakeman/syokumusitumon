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
     //���߂ẴX�g���[�g�V�[���ł������Ƃ��̂݃X�^�[�g��ʂŌo�߂������Ԃ��L�^����
     if(FirstStreet == true)
        {
            StartMenuTime = Mathf.Floor(Time.time);
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        //Limmit�֐��ɃQ�[���J�n������̕b�����擾���ăX�^�[�g���j���[�Ōo�߂������Ԃ������B
        Limmit = Mathf.Floor(Time.time) - StartMenuTime;

        //Limmit���e�L�X�g������.
        string LimmitT = Limmit.ToString();

        //�^�C�}�[�̃R���|�[�l���g���擾
        Text Timer_text = Timer_Object.GetComponent<Text>();

        //�����Ń^�C�}�[�̃e�L�X�g����������
        Timer_text.text = LimmitT;

    }

}
