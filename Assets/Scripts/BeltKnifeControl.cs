using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltKnifeControl : MonoBehaviour
{
    //プレハブ格納用
    public GameObject Knife;

    //ベルトに刃物があるかの関数を呼び出す
    int Belt2 = SelectSomeone.Belt;

    // Start is called before the first frame update
    void Start()
    {
        if (Belt2 == 0)
        {
            //ナイフを既定の位置に生成する
            Vector3 pos = new Vector3(-5.69f, -0.69f);
            Quaternion rot = Quaternion.Euler(0.308f, -0.001f, -0.263f);

            Instantiate(Knife, pos, rot);
        }
        else if (Belt2 == 1) return;
        
    }
}
