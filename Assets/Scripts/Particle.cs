using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {

	[SerializeField]
	private GameObject[] stars;

	[SerializeField]
	private Vector2[] starPositions;

	[SerializeField]
	private GameObject particle;

	private Animator animate;

	[SerializeField]
	private DestroyOther remover;

	void Start (){
		stars = GameObject.FindGameObjectsWithTag ("Star");
		for (int i = 0; i < stars.Length; i++) {
			starPositions[i] = stars[i].transform.position;
		}
	}

	void Update (){
		for (int i = 0; i < stars.Length; i++) {
			if (stars [i] == null) {

				stars[i] = new GameObject ();
				particle.SetActive (true);
				particle.transform.position = starPositions [i];
				StartCoroutine(startAnimation ());
			}
		}
	}

	IEnumerator startAnimation (){
		yield return new WaitForSeconds (1);
		particle.SetActive (false);
	}
}
