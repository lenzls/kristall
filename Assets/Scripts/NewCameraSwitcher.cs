using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraSwitcher : MonoBehaviour
{
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    public GameObject aboveCamera;

    public GameObject player;

    public int cameraMode = 0;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if (cameraMode == 2) 
            {
                cameraMode = 0;
            }
            else 
            {
                cameraMode += 1;
            }
        }
        StartCoroutine(CameraChange());
    }

    IEnumerator CameraChange() 
    {
        yield return new WaitForSeconds(0.01f);
        if (cameraMode == 0)
        {
            firstPersonCamera.SetActive (true);
            thirdPersonCamera.SetActive (false);
            aboveCamera.SetActive (false);
        }
        if (cameraMode == 1)
        {
            firstPersonCamera.SetActive (false);
            thirdPersonCamera.SetActive (true);
            aboveCamera.SetActive (false);
        }
        if (cameraMode == 2)
        {
            firstPersonCamera.SetActive (false);
            thirdPersonCamera.SetActive (false);
            aboveCamera.SetActive (true);
        }
    }
}
