using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CanvasFader : MonoBehaviour
{
    Image _image;
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        _image.color = new Color(0, 0, 0, 1);
        StartFadein();
    }

    public void StartFadein()
    {
        StartCoroutine(FadeIn());
    }

    public void StartFadeout()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeIn()
    {
        while(_image.color.a > 0)
        {
            _image.color = new Color(0, 0, 0, _image.color.a - Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator FadeOut()
    {
        while (_image.color.a < 1)
        {
            _image.color = new Color(0, 0, 0, _image.color.a + Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
    }
}
