using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CandyAnimate : MonoBehaviour {

	[SerializeField]
	private GameObject candy;

	[SerializeField]
	private List<GameObject> star = new List<GameObject>();

	void Start (){
		star.AddRange( GameObject.FindGameObjectsWithTag ("Star"));
	}

	void Update (){
		
		for (int i = 0; i < star.Count; i++) {
			if (star[i] == null) {
				star.RemoveAt (i);
				candy.SetActive (true);
				StartCoroutine(startAnimation ());
			}
		}
	}

	IEnumerator startAnimation (){
		yield return new WaitForSeconds (1);
		candy.SetActive (false);
	}
}
