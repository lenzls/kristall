using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;

public class NewCameraSwitcher : MonoBehaviour
{
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    public GameObject aboveCamera;

    public GameObject player;

    private RigidbodyFirstPersonController m_firstPersonController;
    private ThirdPersonCharacter m_thirdPersonCharacter;
    private ThirdPersonUserControl m_thirdPersonUserControl;

    public int cameraMode = 0;

    void Start()
    {
        m_firstPersonController = player.GetComponent<RigidbodyFirstPersonController>();
        m_thirdPersonCharacter = player.GetComponent<ThirdPersonCharacter>();
        m_thirdPersonUserControl = player.GetComponent<ThirdPersonUserControl>();
        Debug.Log(m_firstPersonController);
        Debug.Log(m_thirdPersonCharacter);
        Debug.Log(m_thirdPersonUserControl);
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
            m_firstPersonController.enabled = true;
            m_thirdPersonCharacter.enabled = false;
            m_thirdPersonUserControl.enabled = false;
            firstPersonCamera.SetActive (true);
            thirdPersonCamera.SetActive (false);
            aboveCamera.SetActive (false);
        }
        if (cameraMode == 1)
        {
            m_firstPersonController.enabled = false;
            m_thirdPersonCharacter.enabled = true;
            m_thirdPersonUserControl.enabled = true;
            firstPersonCamera.SetActive (false);
            thirdPersonCamera.SetActive (true);
            aboveCamera.SetActive (false);
        }
        if (cameraMode == 2)
        {
            m_firstPersonController.enabled = false;
            m_thirdPersonCharacter.enabled = true;
            m_thirdPersonUserControl.enabled = true;
            firstPersonCamera.SetActive (false);
            thirdPersonCamera.SetActive (false);
            aboveCamera.SetActive (true);
        }
    }
}
