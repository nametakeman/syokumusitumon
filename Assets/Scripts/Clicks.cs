using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicks : MonoBehaviour
{

    public void OnClickCharacter()
    {
        ChangeScene;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Select");
    }
}

