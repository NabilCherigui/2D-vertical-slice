using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Animations : MonoBehaviour {

	private List<GameObject> _star = new List<GameObject>();

	private Animator _animates;
	private int _playing = 0;
	private int _randomNumber;

	void Start (){
		_animates = GetComponent<Animator> ();
		_star.AddRange(GameObject.FindGameObjectsWithTag ("Star"));
		_randomNumber = Random.Range (11, 15);
		StartCoroutine(Placing ());
	}

	private void Update (){
		for (int i = 0; i < _star.Count; i++) {
			if (_star[i] == null)
            {
                _star.RemoveAt(i);
                CandyHit();
                StartCoroutine(Reset());
            }	
		}

	}

	private IEnumerator Placing (){

		yield return new WaitForSeconds (_randomNumber);
		_playing = 1;
		SetAnimation ();
		_randomNumber = Random.Range (11, 15);

		yield return new WaitForSeconds (0.417f);
		_playing = 0;
		SetAnimation ();

		StartCoroutine (Placing ());
	}

	private void CandyHit (){
		_playing = 2;
		SetAnimation ();
	}

	private IEnumerator Reset (){

		while (_playing == 2){

			yield return new WaitForSeconds (0.417f);
			_playing = 0;
			SetAnimation ();
		}
	}

	private void SetAnimation (){
		_animates.SetInteger ("Animate", _playing);
	}
}
