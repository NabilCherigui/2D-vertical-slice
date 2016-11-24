using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Star") {
			Destroy (other.gameObject);
		}
	}
}
