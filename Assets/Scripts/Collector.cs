using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Star") {
			Destroy (other.gameObject);
		}
	}
}
