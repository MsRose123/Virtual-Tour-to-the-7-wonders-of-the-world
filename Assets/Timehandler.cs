using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timehandler : MonoBehaviour
{
    const float nSecond = 3f;

    float timer = 0;
    bool entered = false;
    int l;

    public void PointerEnter(int level)
    {
        entered = true;
        l = level;
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
                Application.LoadLevel(l);
            }
        }
        else
        {
            
            timer = 0;
        }
    }
}
