using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class omo : MonoBehaviour
{
    public blueMODEL bluemodel;
    public redMODEL redmodel;
    int Rcount;
    int Bcount;
    int sum;


public void move()
    {
        Rcount = redmodel.akairo;
        Rcount += 1000;

        Bcount = bluemodel.aoiro;
        Bcount += 1000;

        if (Rcount > Bcount)
        {
            sum = Rcount;
        }

        else
        {
            sum = Bcount;
        }

        switch (sum)
        {
            case 1010:
                SceneManager.LoadScene("BASIC");
                break;
            case 1020:
                SceneManager.LoadScene("SLOW");
                break;

            default:
                SceneManager.LoadScene("SampleScene");
                break;
        }
               
           
            
    }
}
