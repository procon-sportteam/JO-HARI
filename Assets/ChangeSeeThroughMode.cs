using GoogleVR.Beta;
using UnityEngine;

public class ChangeSeeThroughMode : MonoBehaviour
{

    private static readonly GvrControllerHand[] AllHands =
    {
            GvrControllerHand.Right,
            GvrControllerHand.Left,
    };

    [Space(15f)] public GameObject[] hideDuringSeeThrough;  //SeeThrough時に非表示にしたいオブジェクトは登録しておく

    void Update()
    {
        foreach (var hand in AllHands)
        {
            GvrControllerInputDevice device = GvrControllerInput.GetDevice(hand);

            //Appボタンが押されたら
            if (device.GetButtonDown(GvrControllerButton.App))
            {
                CycleSeeThroughModes();
            }
        }
    }

    /// <summary>
    /// SeeThroughの表示モードを変更する
    /// </summary>
    private void CycleSeeThroughModes()
    {
        if (!GvrBetaSettings.IsFeatureEnabled(GvrBetaFeature.SeeThrough))
        {
            return;
        }

        GvrBetaSeeThroughCameraMode camMode = GvrBetaHeadset.CameraMode;
        GvrBetaSeeThroughSceneType sceneType = GvrBetaSeeThroughSceneType.Augmented;

        //モードは3種類ありループする
        //VRモード → Rawモード(白黒) → ToneMapモード(セピア調的な)
        switch (camMode)
        {
            case GvrBetaSeeThroughCameraMode.Disabled:
                camMode = GvrBetaSeeThroughCameraMode.RawImage;

                break;
            case GvrBetaSeeThroughCameraMode.RawImage:
                camMode = GvrBetaSeeThroughCameraMode.ToneMap;

                break;
            case GvrBetaSeeThroughCameraMode.ToneMap:
                sceneType = GvrBetaSeeThroughSceneType.Virtual;
                camMode = GvrBetaSeeThroughCameraMode.Disabled;

                break;
        }

        GvrBetaHeadset.SetSeeThroughConfig(camMode, sceneType); //SeeThroughのモード変更

        bool seethruEnabled = camMode != GvrBetaSeeThroughCameraMode.Disabled;
        foreach (var go in hideDuringSeeThrough)
        {
            go.SetActive(!seethruEnabled);  //SeeThroughモードになったと同時に設定しておいたオブジェクトの非表示化
        }
    }
}