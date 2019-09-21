using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menubar : MonoBehaviour
{
    bool check = false;
    public GameObject kakunou;
    public GameObject MenuBar;
    // Start is called before the first frame update
    public void Click()
    {

        if (!check)
        {
            kakunou.SetActive(true);
            check = true;
        }
        else if (check)
        {
            kakunou.SetActive(false);
            check = false;
        }
    }
}
