using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImageFadeAnimation : MonoBehaviour {

	private Image _image;
	private Color _colorOfImage;

	void Start()
	{
		OnEnable ();
	}

	void OnEnable()
	{
		_image = GetComponent<Image> ();
		_colorOfImage = _image.color;
		_colorOfImage.a = 1;
		_image.color = _colorOfImage;
		StartCoroutine(FadeDelay());
	}

	private IEnumerator FadeDelay()
    {
        yield return new WaitForSeconds(2f);

        while (_image.color.a > 0)
		{
			_colorOfImage.a -= 0.1f;
			_image.color = _colorOfImage;
			yield return new WaitForSeconds(0.1f);
		}
		StopCoroutine(FadeDelay());
	}
}
