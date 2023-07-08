using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlus : MonoBehaviour
{

    float Score = StartClick.Score;

    int SelectCharacter = CharacterClicks1.SelectedCharacter;

    // Start is called before the first frame update
    void Start()
    { 
        if(SelectCharacter == 1)
        {
            Score += 2;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
