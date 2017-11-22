using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour
{
    [SerializeField]
    private AudioManager _audioManager;

	[SerializeField]
	private Sprite _grav1;
	[SerializeField]
	private Sprite _grav2;

	private Button _button;

	void Start () {
		_button = GetComponent<Button> ();
	}

	public void ButtonSwitch (){
		if(_button.image.sprite == _grav2)
		{
            _audioManager.PlaySound(_audioManager.Swoosh2);
		    _button.image.sprite = _grav1;

		}
		else if(_button.image.sprite == _grav1)
		{
            _audioManager.PlaySound(_audioManager.Swoosh1);
		    _button.image.sprite = _grav2;
		}
	}
}
