using UnityEngine;
using System.Collections;

/// <summary>
/// This script is responisible for Pause.
/// </summary>

public class Pause : MonoBehaviour {

	[SerializeField] private MenuManagement _canvasHolder; // for the call of the pause canvas.
	[SerializeField] private GameObject _canvasId;

	void Start()
	{
		_canvasHolder = _canvasHolder.GetComponent<MenuManagement> ();
	}

	public void OnPause()
	{
//		print ("Start Pause");
		if(Time.timeScale == 0) { // removes the game from pause.
			Time.timeScale = 1;
			_canvasHolder.SetCanvasFalse (); // disabbles the canvas.
		}
		else if(Time.timeScale == 1) // sets the game on pause.
		{
			Time.timeScale = 0;
			_canvasHolder.OnButtonPress(_canvasId); // enables the given canvas.
		}
	}
}
