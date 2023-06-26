using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterClicks1 : MonoBehaviour
{
    public static int SelectedCharacter;
    //キャラクター識別用の変数を宣言 

    public void OnClickCharacter1()
    {
        //キャラクター識別用の変数にヤンキーの1を代入 
        SelectedCharacter = 1;
        
        ChangeScene();
    }

    //シーン切り替え用の関数
    void ChangeScene()
    {
        Debug.Log(SelectedCharacter);
        SceneManager.LoadScene("Select");
    }
}

