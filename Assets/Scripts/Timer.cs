using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerS : MonoBehaviour
{
    
    public float Limmit;

    public GameObject Timer_object;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mathf.Floor�ŏ����_�؂�̂āBTIme.time�ŃQ�[���J�n����̌v��
        Limmit = Mathf.Floor(Time.time);

        //�I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text Timer_text = Timer_object.GetComponent<Text>();
    }

}
