using S3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDisableCameraRotation : MonoBehaviour
{

    private float fov;
    private float maxFOV;
    private GameObject player;
    private GameManager_Master gameManagerMaster;
    private bool hasCutsceneTerminatedEventBeenCalled;


    // Use this for initialization
    void Start()
    {
        SetInitialReferences();
    }

    // Update is called once per frame
    void Update()
    {
        fov = GameManager_References._mainCamera.GetComponent<CameraFOV>().fov;
        if (IsCameraZoomedOut())
        {
            GivePlayerControl();
        }

    }

    bool IsCameraZoomedOut()
    {
        if (fov != 0)
        {
            return fov >= maxFOV;
        }
        else return false;
    }

    private void SetInitialReferences()
    {
        player = GameManager_References._player;
        maxFOV = GameManager_References._mainCamera.GetComponent<CameraFOV>().maxFOV;
        gameManagerMaster = GetComponent<GameManager_Master>();
        hasCutsceneTerminatedEventBeenCalled = false;
    }

    private void GivePlayerControl()
    {
        if (!hasCutsceneTerminatedEventBeenCalled)
        {
            gameManagerMaster.CallCutsceneTerminatedEvent();
            hasCutsceneTerminatedEventBeenCalled = true;
        }
    }
}
