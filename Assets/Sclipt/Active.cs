using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{ 
    public GameObject ControllerVisualMulti;
    GvrControllerInputDevice gvrControllerInput;
    [SerializeField]
    private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;

    void Start()
    {
        gvrControllerInput = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
    }

    void Update()
    {
        if (gvrControllerInput.GetButtonDown(GvrControllerButton.App))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                ControllerVisualMulti.SetActive(false);
            }
    
        }

        else
        {
                Destroy(pauseUIInstance);
            ControllerVisualMulti.SetActive(false);
        }
    }
}
