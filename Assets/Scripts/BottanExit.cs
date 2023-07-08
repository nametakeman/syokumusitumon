using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottanExit : MonoBehaviour
{
    
    public void OnClickExit()
    {
        string NowScene = SceneManager.GetActiveScene().name;

        if (NowScene == "Select")
        {
            string NextScene = "Street";
            ChangeScene(NextScene);
        }
        else if (NowScene == "Belt")
        {
            string NextScene = "Select";
            ChangeScene(NextScene);
        }
        else if (NowScene == "Shoes")
        {
            string NextScene = "Select";
            ChangeScene(NextScene);
        }
        else if (NowScene == "Taiho")
        {
            string NextScene = "Street";
            ChangeScene(NextScene);
        }
        else if (NowScene == "End")
        {
            string NextScene = "StartMenu";
            ChangeScene(NextScene);
        }

    }

    void ChangeScene(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }
}
