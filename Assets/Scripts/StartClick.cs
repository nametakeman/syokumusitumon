using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    
    public void OnclickStart()
    {
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Street");
    }
}
