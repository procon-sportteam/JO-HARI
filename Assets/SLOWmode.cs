using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SLOWmode : MonoBehaviour
{

    void Start()
    {

    }

    public void Event()
    {
        SceneManager.LoadScene("SLOW");
    }
}