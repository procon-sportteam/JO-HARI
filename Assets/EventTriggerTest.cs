using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EventTriggerTest : MonoBehaviour
{

    void Start()
    {

    }

    public void Event()
    {
        SceneManager.LoadScene("SlowScene");
    }
}