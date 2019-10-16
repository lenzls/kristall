using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    
    private Vector3 initialPosition;
    public GameObject tryAgainText;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monster")) {
            // Destroy(other.gameObject);
            tryAgainText.GetComponent<TextFadeability>().Fade();
            transform.position = initialPosition;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }

}
