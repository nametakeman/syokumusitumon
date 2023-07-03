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
        //Mathf.Floorで小数点切り捨て。TIme.timeでゲーム開始からの計測
        Limmit = Mathf.Floor(Time.time);

        //オブジェクトからTextコンポーネントを取得
        Text Timer_text = Timer_object.GetComponent<Text>();
    }

}
