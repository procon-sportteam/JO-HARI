using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelbar : MonoBehaviour
{
    public GameObject kakunou;
    public GameObject MenuBar;
    public GameObject modelchoose;
    // Start is called before the first frame update
    public void Click()
    {
        {
            modelchoose.SetActive(true);
            MenuBar.SetActive(false);
            kakunou.SetActive(false);
        }

     
    }
}
