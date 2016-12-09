using UnityEngine;
using System.Collections;

/// <summary>
/// Menu management.
/// is responisible for activating and deactivating canvases.
/// </summary>

public class MenuManagement : MonoBehaviour {

	[SerializeField]
	private GameObject[] _canvas; // canvas 0 is Main Canvas = is active;

	// Use this for initialization
	void Start ()
	{
		SetCanvasFalse ();
		_canvas [0].SetActive (true); //sets all Canvas of disabled except the first.
	}

	public void OnButtonPress (GameObject canvasId)
	{
	    SetCanvasFalse ();
	    foreach (GameObject t in _canvas)
	    {
	        if (t.name == canvasId.name) // sets only the given canvas active.
	        {
	            t.SetActive (true);
	        }
	    }
	}

	public void SetCanvasFalse()
	{
	    foreach (GameObject t in _canvas)
	    {
	        t.SetActive (false); // sets every canvas off.
	    }
	}
}
