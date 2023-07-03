using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float Limmit; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Limmit = Mathf.Floor(Time.time);
        Debug.Log(Limmit);
    }

}
