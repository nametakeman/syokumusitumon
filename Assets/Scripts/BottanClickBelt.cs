using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottanClickBelt : MonoBehaviour
{
    
    public void OnClickBottanBelt()
    {
        ChangeScene();
    }

    
    void ChangeScene()
    {
        SceneManager.LoadScene("Belt");
    }
}
