using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoesKnifeControl : MonoBehaviour
{
    //�v���n�u�i�[�p
    public GameObject Knife;

    //�N�c�ɐn�������邩�̊֐����Ăяo��
    int Shoes2 = SelectSomeone.Shoes;

    // Start is called before the first frame update
    void Start()
    {
        if (Shoes2 == 0)
        {
            //�i�C�t������̈ʒu�ɐ�������
            Vector3 pos = new Vector3(-2.16f, -0.69f);
            Quaternion rot = Quaternion.Euler(0, 0, -91.295f);

            Instantiate(Knife, pos, rot);

        }
        else if (Shoes2 == 1) return;
    }
}
