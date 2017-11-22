using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CandyAnimate : MonoBehaviour {

	//A list is created for the stars.
	[SerializeField]
	private GameObject _candy;
	private List<GameObject> _star = new List<GameObject>();

	//The list is filled with gameobjects that have the tag "Star".
	void Start (){
		_star.AddRange( GameObject.FindGameObjectsWithTag ("Star"));
	}

	//If a star disappears it gets removed from the list, the gameobject that candy holds is made active and the coroutine startAnimation is activated.
	void Update (){
		for (int i = 0; i < _star.Count; i++) {
			if (_star[i] == null) {
				_star.RemoveAt (i);
				_candy.SetActive (true);
				StartCoroutine(startAnimation ());
			}
		}
	}

	//The coroutine waits for 1 second so the animation can completely finish playing and the candy is deactivated.
	IEnumerator startAnimation (){
		yield return new WaitForSeconds (1);
		_candy.SetActive (false);
	}
}
