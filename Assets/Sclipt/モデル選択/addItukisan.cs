using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addItukisan : MonoBehaviour
{
    private int Icount;
 
    public int GetIcount()
    {
        return Icount;
    }

    private int modelnumberB;

    public int GetmodelnumberB()
    {
        return modelnumberB;
    }

    public addAnzai addanzai;
    public GameObject itukisan;
    public GameObject modelchoose;
    public GameObject menubar;
    public GameObject warning;
    public GameObject batu;
 

    public void Click()
    {
        int Acount;
        Acount = addanzai.GetAcount();
        switch (Acount)
        {
            case 0:
                if(Icount == 1)
                {
                    Instantiate(itukisan, new Vector3(0f, -1.691702f, 6.086083f), Quaternion.identity);
                    modelchoose.SetActive(false);
                    menubar.SetActive(true);
                    Icount += 1;
                    modelnumberB = 2;
                }
                else if(Icount == 0)
                {
                    Instantiate(itukisan, new Vector3(-2f, -1.691702f, 6.086083f), Quaternion.identity);
                    modelchoose.SetActive(false);
                    menubar.SetActive(true);
                    Icount += 1;
                    modelnumberB = 1;
                }
                else
                {
                    warning.SetActive(true);
                    batu.SetActive(true);
                    menubar.SetActive(false);
                    modelchoose.SetActive(false);
                }
                break;
            case 1:
                if(Icount == 0)
                {
                    Instantiate(itukisan, new Vector3(0f, -1.691702f, 6.086083f), Quaternion.identity);
                    modelchoose.SetActive(false);
                    menubar.SetActive(true);
                    Icount += 1;
                    modelnumberB = 100;
                }
                else
                {
                    warning.SetActive(true);
                    batu.SetActive(true);
                    menubar.SetActive(false);
                    modelchoose.SetActive(false);
                }
                break;
            case 2:
                warning.SetActive(true);
                batu.SetActive(true);
                menubar.SetActive(false);
                modelchoose.SetActive(false);
                break;
        }

   
    }
}
