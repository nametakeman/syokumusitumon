using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoesKnifeControl : MonoBehaviour
{
    //プレハブ格納用
    public GameObject Knife;

    //クツに刃物があるかの関数を呼び出す
    int Shoes2 = SelectSomeone.Shoes;

    // Start is called before the first frame update
    void Start()
    {
        if (Shoes2 == 0)
        {
            //ナイフを既定の位置に生成する
            Vector3 pos = new Vector3(-2.16f, -0.69f);
            Quaternion rot = Quaternion.Euler(0, 0, -91.295f);

            Instantiate(Knife, pos, rot);

        }
        else if (Shoes2 == 1) return;
    }
}
