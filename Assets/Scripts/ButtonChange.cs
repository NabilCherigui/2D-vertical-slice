using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour {
	[SerializeField]
	private Sprite grav1;
	[SerializeField]
	private Sprite grav2;

	private Button button;

	void Start () {
		button = GetComponent<Button> ();
	}

	public void ButtonSwitch (){
		if(button.image.sprite == grav2)
		{
			button.image.sprite = grav1;
		}
		else if(button.image.sprite == grav1)
		{
			button.image.sprite = grav2;
		}
	}
}
