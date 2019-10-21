using System;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;

public class MouseLookTrigger : MonoBehaviour
{
    [SerializeField] public MouseLook m_MouseLook;

    public Camera m_firstPersonCamera;

    private void Start()
    {
        m_MouseLook.Init(transform , m_firstPersonCamera.transform);
    }

    private void Update()
    {
        RotateView();
    }

    private void FixedUpdate()
    {
        m_MouseLook.UpdateCursorLock();
    }

    private void RotateView()
    {
        m_MouseLook.LookRotation (transform, m_firstPersonCamera.transform);
    }
}
