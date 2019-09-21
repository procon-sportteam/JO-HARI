using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addAnzai : MonoBehaviour
{
    private int Acount;
    public int GetAcount()
    {
        return Acount;
    }

    private int modelnumber;
    public int Getmodelnumber()
    {
        return modelnumber;
    }

    public addItukisan additukisan;
    public GameObject warning;
    public GameObject batu;
    public GameObject anzai;
    public GameObject modelchoose;
    public GameObject menubar;


    public void Click()
    {
        int Icount;
        Icount = additukisan.GetIcount();
        switch (Icount)
        {
            case 0:
                if(Acount == 1)
                {
                    Instantiate(anzai, new Vector3(0f, -1.691702f, 6.086083f), Quaternion.identity);
                    modelchoose.SetActive(false);
                    menubar.SetActive(true);
                    Acount += 1;
                    modelnumber = 2;
                }
                else if(Acount == 0)
                {
                    Instantiate(anzai, new Vector3(-2f, -1.691702f, 6.086083f), Quaternion.identity);
                    modelchoose.SetActive(false);
                    menubar.SetActive(true);
                    Acount += 1;
                    modelnumber = 1;
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
                if(Acount == 0)
                {
                    Instantiate(anzai, new Vector3(0f, -1.691702f, 6.086083f), Quaternion.identity);
                    modelchoose.SetActive(false);
                    menubar.SetActive(true);
                    Acount += 1;
                    modelnumber = 100;
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
