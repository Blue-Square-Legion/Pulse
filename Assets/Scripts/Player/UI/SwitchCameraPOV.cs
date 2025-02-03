using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraPOV : MonoBehaviour
{
    [Header("Add cameras to this list")]
    public List<Camera> cameras = new List<Camera>();

    private int currentCameraIndex = 0;

    void Start()
    {
        // Ensure only the first camera is enabled at the start
        UpdateCameras();
    }

    void Update()
    {
        // Check if the M key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Move to the next camera index
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Count;
            UpdateCameras();
        }
    }

    private void UpdateCameras()
    {
        // Enable the current camera and disable the rest
        for (int i = 0; i < cameras.Count; i++)
        {
            if (cameras[i] != null)
            {
                cameras[i].enabled = (i == currentCameraIndex);
            }
        }
    }
}
