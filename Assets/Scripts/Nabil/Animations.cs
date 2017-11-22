using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Animations : MonoBehaviour {
	
	//A list is created for the stars.
	private List<GameObject> _star = new List<GameObject>();

	private Animator _animates;
	private int _playing = 0;
	private int _randomNumber;

	//animates hold the gameobjects animator component. The list is filled with all the object with the tag "Star". randomNumber contains a random number from 11 to 15. The Placing coroutine starts.
	void Start (){
		_animates = GetComponent<Animator> ();
		_star.AddRange(GameObject.FindGameObjectsWithTag ("Star"));
		_randomNumber = Random.Range (11, 15);
        //StartCoroutine(Placing ()); Not being used, animation is not finished.
    }

    //If a star disappears it gets removed from the list, the CandyHit function starts and the Reset coroutine starts.
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

	/*The coroutine waits for seconds equal to randomNumber. playing equals 1. SetAnimation starts. randomNumber get a new random range. It waits for 0.417 seconds so the animation can completely finish playing.
	playing now equals 0. SetAnimation is activated. The coroutine activates itself.*/ 
	/*
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
    */

	//playing equals 2. SetAnimation gets activated.
	private void CandyHit ()
    {
		_playing = 2;
		SetAnimation ();
	}

	//If playing equals 2 the coroutine will wait for 0.417 seconds so the animation can completely finish playing. playing now equals 0 and SetAnimation gets activated.
	private IEnumerator Reset (){

		if (_playing == 2){

			yield return new WaitForSeconds (0.417f);
			_playing = 0;
			SetAnimation ();
		}
	}

	//In the Animator the value of the Parameter 'Animate' is made to equal the variable playing. This plays different animations according to the value of playing.     
	private void SetAnimation (){
		_animates.SetInteger ("Animate", _playing);
	}
}
