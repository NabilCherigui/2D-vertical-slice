using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {
	[SerializeField]
	private GameObject Target;

	[SerializeField]
	private GameObject[] star;

	private Animator Animates;
	private int playing = 0;

	void Start (){
		Animates = GetComponent<Animator> ();
		star = GameObject.FindGameObjectsWithTag ("Star");
	}

	void Update (){
		if (Target.transform.position.x > -2.5 && Target.transform.position.x < -1) {
			Place ();
		} 
		else {
			StartCoroutine (Placing ());
		}

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

	public void Place (){
		playing = 1;
		SetAnimation ();
	}

	IEnumerator Placing (){
		
		while (playing == 1){
			
			yield return new WaitForSeconds (0.417f);
			playing = 0;
			SetAnimation ();
		}
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
