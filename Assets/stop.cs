using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    bool check = false;

    public void Click()
    {
        if (!check)
        { 
            Time.timeScale = 0f;
            check = true;
        }
        else if (check)
        {
            Time.timeScale = 1f;
            check = false;

        }

    }
}
