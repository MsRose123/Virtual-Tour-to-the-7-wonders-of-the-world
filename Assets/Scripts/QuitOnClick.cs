using UnityEngine;
using System.Collections;

public class QuitOnClick : MonoBehaviour
{
    const float nSecond = 3f;

    float timer = 0;
    bool entered = false;
    int l;

    public void PointerEnter()
    {
        entered = true;
    }

    public void PointerExit()
    {
        entered = false;
    }

    void Update()
    {
        
        if (entered)
        {
            
            timer += Time.deltaTime;

            
            if (timer > nSecond)
            {
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #else
                    Application.Quit();
                #endif

            }
        }
        else
        {
            
            timer = 0;
        }
    }
    

}