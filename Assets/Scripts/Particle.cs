using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {

	[SerializeField]
	private GameObject[] _stars;

	[SerializeField]
	private Vector2[] _starPositions;

	[SerializeField]
	private GameObject _particle;

	private Animator _animate;

	[SerializeField]
	private DestroyOther _remover;

	void Start (){
		_stars = GameObject.FindGameObjectsWithTag ("Star");
		for (int i = 0; i < _stars.Length; i++) {
			_starPositions[i] = _stars[i].transform.position;
		}
	}

	void Update (){
		for (int i = 0; i < _stars.Length; i++) {
			if (_stars [i] == null) {

				_stars[i] = new GameObject ();
				_particle.SetActive (true);
				_particle.transform.position = _starPositions [i];
				StartCoroutine(startAnimation ());
			}
		}
	}

	IEnumerator startAnimation (){
		yield return new WaitForSeconds (1);
		_particle.SetActive (false);
	}
}
