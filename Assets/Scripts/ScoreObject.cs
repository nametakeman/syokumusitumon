using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreObject : MonoBehaviour
{

    float Score = ScorePlus.Score;

    public GameObject Score_Object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string ScoreS = Score.ToString();

        Text Score_text = Score_Object.GetComponent<Text>();

        Score_text.text = "Score:" + ScoreS;
    }
}
