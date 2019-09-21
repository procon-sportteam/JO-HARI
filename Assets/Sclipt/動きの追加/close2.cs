using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close2 : MonoBehaviour
{
    public GameObject nomodel;
    public GameObject batu2;
    public GameObject menubar;

    public void Click()
    {
        nomodel.SetActive(false);
        batu2.SetActive(false);
        menubar.SetActive(true);
    }
}
