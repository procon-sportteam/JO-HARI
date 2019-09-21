using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow : MonoBehaviour
{
    bool check = false;

    public void Click()
    {
        if (!check)
        {
            Time.timeScale = 0.5f;
            check = true;
        }
        else if (check)
        {
            Time.timeScale = 1f;
            check = false;

        }

    }
}
