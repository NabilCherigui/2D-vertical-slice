using UnityEngine;
using System.Collections;

public class StarCounter : MonoBehaviour {

	void Update () {
		if ((GameObject.Find("Star") == null)) {
			gameObject.GetComponent<Renderer> ().enabled = true;
		} 
		else 
		{
			gameObject.GetComponent<Renderer> ().enabled = false;

		}
	}
}
