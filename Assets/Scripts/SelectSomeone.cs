using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSomeone : MonoBehaviour
{
    //プレハブ格納用
    public GameObject Character1FPrefab;

    //どのキャラクターが選ばれたかの変数を持ってくる
    int SelectedCharacter2 = CharacterClicks1.SelectedCharacter;

    //キャラクターが悪である確率
    public int Character1Pro;

    public static int Shoes;
    public static int Belt;

    // Start is called before the first frame update
    void Start()
    {
        //キャラクターが悪か善かを決定するキャラクター固有の値を付与する
        int ZenAku = Random.Range(1,100);

        //まずキャラクターによって異なるオブジェクトを設置 
        if (SelectedCharacter2 == 1)
        {
            Vector3 pos = new Vector3(0.15f,0.45f);

            Instantiate(Character1FPrefab, pos, Quaternion.identity);

            //キャラクターが悪だった場合どこに刃物があるかを決める,確率はCharacter1Proによって決定
            if (ZenAku <= Character1Pro)
            {
                //値が1であるならクツ,2であるならベルトとする
                int WhereKnife = Random.Range(1,100);

                //クツに刃物があるときpublic変数にどちらであるかを代入
                if (WhereKnife <= 50) {
                    Shoes = 0;
                    Belt = 1;
                }else if(WhereKnife > 50)
                {
                    Shoes = 1;
                    Belt = 0;
                }
            }
            else
            {
                Shoes=1;
                Belt = 1;
            }
           
        }


    }
}
