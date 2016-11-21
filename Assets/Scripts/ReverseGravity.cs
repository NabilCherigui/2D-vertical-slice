using UnityEngine;
using System.Collections;

public class ReverseGravity : MonoBehaviour {
	private Rigidbody2D rigidBody;

	void Start ()
	{
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	public void Reverse()
	{
		rigidBody.gravityScale *= -1;
	}
}
