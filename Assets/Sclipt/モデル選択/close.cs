using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
    public GameObject warning;
    public GameObject batu;
    public GameObject menubar;

    public void Click()
    {
        warning.SetActive(false);
        batu.SetActive(false);
        menubar.SetActive(true);
    }
}
