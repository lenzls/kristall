using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextFadeability : MonoBehaviour
{
    public float fadeInTime;
    public float showTime;
    public float fadeOutTime;

    public Color colour;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fade()
    {
        StartCoroutine(FadeRoutine());
    }


    private IEnumerator FadeRoutine()
    { 
        Text text = GetComponent<Text>();
        
        // Fade In
        for (float t = 0.01f; t < fadeInTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(Color.clear, colour, Mathf.Min(1, t/fadeInTime));
            yield return null;
        }
        
        // Show
        for (float t = 0.01f; t < showTime; t += Time.deltaTime)
        {
            yield return null;
        }

        // Fade Out
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(colour, Color.clear, Mathf.Min(1, t/fadeOutTime));
            yield return null;
        }
    }

}
