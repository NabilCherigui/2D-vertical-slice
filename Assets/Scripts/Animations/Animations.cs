using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	[SerializeField]
	private GameObject[] star;

	private Animator Animates;
	private int playing = 0;
	private int randomNumber;

	void Start (){
		Animates = GetComponent<Animator> ();
		star = GameObject.FindGameObjectsWithTag ("Star");
		randomNumber = Random.Range (11, 15);
		StartCoroutine(Placing ());
	}

	void Update (){
		for (int i = 0; i < star.Length; i++) {
			if (star[i] == null) {
				Test ();
				star[i] = new GameObject ();
			} 
			else {
				StartCoroutine (Testing ());
			}	
		}

	}

	IEnumerator Placing (){

		yield return new WaitForSeconds (randomNumber);
		playing = 1;
		SetAnimation ();
		randomNumber = Random.Range (11, 15);

		yield return new WaitForSeconds (0.417f);
		playing = 0;
		SetAnimation ();

		StartCoroutine (Placing ());
	}

	public void Test (){
		playing = 2;
		SetAnimation ();
	}

	IEnumerator Testing (){

		while (playing == 2){

			yield return new WaitForSeconds (0.417f);
			playing = 0;
			SetAnimation ();
		}
	}

	private void SetAnimation (){
		Animates.SetInteger ("Animate", playing);
	}
}
