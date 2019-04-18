using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveButton : MonoBehaviour
{
     void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnGazeEnter(int level)
    {
        Debug.Log ("Gaze Entered");
        Application.LoadLevel(level);
    }
}
