using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlus : MonoBehaviour
{

    public static float Score;

    int SelectCharacter = 1;

    // Start is called before the first frame update
    void Start()
    { 
        if(SelectCharacter == 1)
        {
            Score = 2;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
