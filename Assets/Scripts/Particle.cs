using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Particle : MonoBehaviour {

	private List<GameObject> _stars = new List<GameObject>();
	private List<Vector2> _starPositions = new List<Vector2>();

	[SerializeField]
	private GameObject _particle;

	void Start (){
		_stars.AddRange(GameObject.FindGameObjectsWithTag ("Star"));
		for (int i = 0; i < _stars.Count; i++)
        {
			_starPositions.Add(_stars[i].transform.position);
		}
	}

	void Update (){
		for (int i = 0; i < _stars.Count; i++)
        {
			if (_stars [i] == null)
            {
                _stars.RemoveAt(i);
				_particle.SetActive (true);
				_particle.transform.position = _starPositions [i];
                _starPositions.RemoveAt(i);
				StartCoroutine(startAnimation ());
			}
		}
	}

	IEnumerator startAnimation (){
		yield return new WaitForSeconds (0.3f);
		_particle.SetActive (false);
	}
}
