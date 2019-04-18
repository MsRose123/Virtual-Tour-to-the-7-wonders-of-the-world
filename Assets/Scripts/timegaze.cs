using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timegaze : MonoBehaviour
{
    // Start is called before the first frame update
    const float nSecond = 6f;

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
        //If pointer is pointing on the object, start the timer
        if (entered)
        {
            //Increment timer
            timer += Time.deltaTime;

            //Load scene if counter has reached the nSecond
            if (timer > nSecond)
            {
                Application.LoadLevel(l);
            }
        }
        else
        {
            //Reset timer when it's no longer pointing
            timer = 0;
        }
    }
}
