using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Particle : MonoBehaviour {

	//Lists are created for the stars and their positions
	private List<GameObject> _stars = new List<GameObject>();
	private List<Vector2> _starPositions = new List<Vector2>();

	//This is the gameobject that has the animation
	[SerializeField]
	private GameObject _particle;

	//The lists are filled with the stars and their positions
	void Start (){
		_stars.AddRange(GameObject.FindGameObjectsWithTag ("Star"));
		for (int i = 0; i < _stars.Count; i++)
        {
			_starPositions.Add(_stars[i].transform.position);
		}
	}

	/*If a star disappears it gets removed. The gameobject holding the animation moves to the position of the removed star and plays its animation.
	The stars position gets removed from the list. The coroutine starts so the animation can play completely before it is turned off again.*/
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
	//Waits for 0.3 seconds and then turns the gameobject off.
	IEnumerator startAnimation (){
		yield return new WaitForSeconds (0.3f);
		_particle.SetActive (false);
	}
}
