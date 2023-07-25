using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class camera : MonoBehaviour
{

    public CinemachineVirtualCamera[] virtualCameras;

    void Start()
    {
        SwitchToCamera(virtualCameras[0]);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchToCamera(virtualCameras[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchToCamera(virtualCameras[1]);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchToCamera(virtualCameras[2]);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SwitchToCamera(virtualCameras[3]);
        }
    }
    private void SwitchToCamera(CinemachineVirtualCamera targetCamera)
    {

        foreach (CinemachineVirtualCamera camera in virtualCameras)
        {
            camera.enabled = camera == targetCamera;
        }
    }
}
