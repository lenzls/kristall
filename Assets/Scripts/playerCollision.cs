using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class playerCollision : MonoBehaviour
{
    
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    public GameObject tryAgainText;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monster")) {
            // Destroy(other.gameObject);
            Debug.Log("collission with monster!########################################################################################################");

            tryAgainText.GetComponent<TextFadeability>().Fade();

            transform.position = initialPosition;
            GetComponent<FirstPersonController>().m_MouseLook.ResetCharacterTargetRot(initialRotation);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }

}
