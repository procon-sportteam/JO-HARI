using UnityEngine;
using System.Collections;

public class Halt : MonoBehaviour
{
    GvrControllerInputDevice gvrControllerInput;

    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    void Start()
    {
        gvrControllerInput = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
    }
    // Update is called once per frame
    void Update()
    {
        if (gvrControllerInput.GetButtonDown(GvrControllerButton.TouchPadButton))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }
}