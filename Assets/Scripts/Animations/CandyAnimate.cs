using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CandyAnimate : MonoBehaviour {

	[SerializeField]
	private GameObject _candy;
	private List<GameObject> _star = new List<GameObject>();

	void Start (){
		_star.AddRange( GameObject.FindGameObjectsWithTag ("Star"));
	}

	void Update (){
		
		for (int i = 0; i < _star.Count; i++) {
			if (_star[i] == null) {
				_star.RemoveAt (i);
				_candy.SetActive (true);
				StartCoroutine(startAnimation ());
			}
		}
	}

	IEnumerator startAnimation (){
		yield return new WaitForSeconds (1);
		_candy.SetActive (false);
	}
}
