using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeClicks : MonoBehaviour
{
    
    public void OnclickKnife()
    {
        ChangeScene();
    }

    
    void ChangeScene()
    {
        SceneManager.LoadScene("Taiho");
    }
}
