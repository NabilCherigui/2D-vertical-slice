using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImageFadeAnimation : MonoBehaviour {

	private Image image;
	private Color colorOfImage;

	void Start()
	{
		OnEnable ();
	}

	void OnEnable()
	{
		image = GetComponent<Image> ();
		colorOfImage = image.color;
		colorOfImage.a = 1;
		image.color = colorOfImage;
		StartCoroutine(FadeDelay());
	}

	private IEnumerator FadeDelay()
    {
        yield return new WaitForSeconds(2f);

        while (image.color.a > 0)
		{
			colorOfImage.a -= 0.1f;
			image.color = colorOfImage;
			yield return new WaitForSeconds(0.1f);
		}
		StopCoroutine(FadeDelay());
	}
}
