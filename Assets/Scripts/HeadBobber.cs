// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityStandardAssets.Utility;

// public class HeadBobber : MonoBehaviour
// {
//     [SerializeField] public bool m_UseHeadBob;
//     [SerializeField] private CurveControlledBob m_HeadBob = new CurveControlledBob();
//     [SerializeField] private LerpControlledBob m_JumpBob = new LerpControlledBob();
//     [SerializeField] private float m_StepInterval;
        
//     private Camera m_Camera;
//     private RigidBody m_RigidBody;

//     private boolean m_IsWalking;

//     // Start is called before the first frame update
//     void Start()
//     {
//         m_Camera = GetComponent<NewCameraSwitcher>().firstPersonCamera.GetComponent<Camera>();
//         m_HeadBob.Setup(m_Camera, m_StepInterval);
//         m_RigidBody = GetComponent<RigidBody>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         UpdateCameraPosition(speed);
//     }

//     private void UpdateCameraPosition(float speed)
//     {
//         Vector3 newCameraPosition;
//         if (!m_UseHeadBob)
//         {
//             return;
//         }
//         if (m_RigidBody.velocity.magnitude > 0)
//         {
//             m_Camera.transform.localPosition =
//                 m_HeadBob.DoHeadBob(m_RigidBody.velocity.magnitude +
//                                     (speed*(m_IsWalking ? 1f : m_RunstepLenghten)));
//             newCameraPosition = m_Camera.transform.localPosition;
//             newCameraPosition.y = m_Camera.transform.localPosition.y - m_JumpBob.Offset();
//         }
//         else
//         {
//             newCameraPosition = m_Camera.transform.localPosition;
//             newCameraPosition.y = m_OriginalCameraPosition.y - m_JumpBob.Offset();
//         }
//         m_Camera.transform.localPosition = newCameraPosition;
//     }

//     private void GetInput(out float speed)
//     {
//         // Read input
//         float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
//         float vertical = CrossPlatformInputManager.GetAxis("Vertical");

//         bool waswalking = m_IsWalking;

// #if !MOBILE_INPUT
//         // On standalone builds, walk/run speed is modified by a key press.
//         // keep track of whether or not the character is walking or running
//         m_IsWalking = !Input.GetKey(KeyCode.LeftShift);
// #endif
//         // set the desired speed to be walking or running
//         speed = m_IsWalking ? m_WalkSpeed : m_RunSpeed;
//         m_Input = new Vector2(horizontal, vertical);

//         // normalize input if it exceeds 1 in combined length:
//         if (m_Input.sqrMagnitude > 1)
//         {
//             m_Input.Normalize();
//         }

//         // handle speed change to give an fov kick
//         // only if the player is going to a run, is running and the fovkick is to be used
//         if (m_IsWalking != waswalking && m_UseFovKick && m_CharacterController.velocity.sqrMagnitude > 0)
//         {
//             StopAllCoroutines();
//             StartCoroutine(!m_IsWalking ? m_FovKick.FOVKickUp() : m_FovKick.FOVKickDown());
//         }
//     }

// }
