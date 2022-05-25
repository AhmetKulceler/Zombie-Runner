using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    [SerializeField] float normalFOV = 60f;
    [SerializeField] float zoomedInFOV = 25f;
    [SerializeField] float normalSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = 0.75f;

    bool zoomToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;

        fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
    }

    private void ZoomOut()
    {
        zoomToggle = false;
        fpsCamera.fieldOfView = normalFOV;

        fpsController.mouseLook.XSensitivity = normalSensitivity;
        fpsController.mouseLook.YSensitivity = normalSensitivity;
    }
}
