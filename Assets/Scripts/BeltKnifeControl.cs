using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltKnifeControl : MonoBehaviour
{
    //�v���n�u�i�[�p
    public GameObject Knife;

    //�x���g�ɐn�������邩�̊֐����Ăяo��
    int Belt2 = SelectSomeone.Belt;

    // Start is called before the first frame update
    void Start()
    {
        if (Belt2 == 0)
        {
            //�i�C�t������̈ʒu�ɐ�������
            Vector3 pos = new Vector3(-5.69f, -0.69f);
            Quaternion rot = Quaternion.Euler(0.308f, -0.001f, -0.263f);

            Instantiate(Knife, pos, rot);
        }
        else if (Belt2 == 1) return;
        
    }
}
