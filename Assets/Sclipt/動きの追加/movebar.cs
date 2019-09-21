using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebar : MonoBehaviour
{
    public addAnzai addanzai;
    public addItukisan additukisan;
    public GameObject kakunou;
    public GameObject MenuBar;
    public GameObject movechoose;
    public GameObject nomodel;
    public GameObject anzaiitukisan;
    public GameObject anzaizai;
    public GameObject itukisansan;
   

    // Start is called before the first frame update
    public void Click()
    {
        int modelnumber;
        modelnumber = addanzai.Getmodelnumber();
        int modelnumberB;
        modelnumberB = additukisan.GetmodelnumberB();

        switch (modelnumber)
        {
            //anzaiが表示されていないとき
            case 0:
                //itukisanが一人選ばれた場合
                if(modelnumberB == 1)
                {
                    movechoose.SetActive(true);
                    MenuBar.SetActive(false);
                    kakunou.SetActive(false);
                }
                //itukisanが二人選ばれた場合
                else if(modelnumberB == 2)
                {
                    itukisansan.SetActive(true);
                    MenuBar.SetActive(false);
                    kakunou.SetActive(false);
                }
                break;

            //anzaiが一人表示されているとき
            case 1:
                movechoose.SetActive(true);
                MenuBar.SetActive(false);
                kakunou.SetActive(false);
                

                if(modelnumberB == 100)
                {
                    anzaiitukisan.SetActive(true);
                    MenuBar.SetActive(false);
                    kakunou.SetActive(false);
                }
                break;

            case 2:
                anzaizai.SetActive(true);
                MenuBar.SetActive(false);
                kakunou.SetActive(false);
                break;

            default:
                nomodel.SetActive(true);
                MenuBar.SetActive(false);
                kakunou.SetActive(false);
                break;

            case 100:
                anzaiitukisan.SetActive(true);
                MenuBar.SetActive(false);
                kakunou.SetActive(false);
                break;
        }
        

        
     
    }
}
