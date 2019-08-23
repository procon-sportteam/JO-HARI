using UnityEngine;
using System.Collections;

public class Speed: MonoBehaviour
{
    GvrControllerInputDevice gvrControllerInput;

    void Start()
    {
        gvrControllerInput = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
    }

    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    // Update is called once per frame
    void Update()
    {
        if (gvrControllerInput.GetButtonDown(GvrControllerButton.System))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0.5f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }
}