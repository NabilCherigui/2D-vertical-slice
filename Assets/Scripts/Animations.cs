using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {
	[SerializeField]
	private GameObject Target;

	private Animator Animates;

	private int playing = 0;

	void Start (){
		Animates = GetComponent<Animator> ();
	}

	void Update (){
		if (Target.transform.position.x > -2.5 && Target.transform.position.x < -1){
			Place ();
		}
	}

	public void Place (){
		playing = 1;
		Animates.SetInteger ("Animate", playing);
		StartCoroutine (Placing ());
	}

	IEnumerator Placing (){
		
		while (playing == 1){
			
			yield return new WaitForSeconds (0.417f);
			playing = 0;
			Animates.SetInteger ("Animate", playing);
		}
	}

	public void Test (){
		playing = 2;
		Animates.SetInteger ("Animate", playing);
		StartCoroutine (Testing ());
	}

	IEnumerator Testing (){

		while (playing == 2){

			yield return new WaitForSeconds (0.417f);
			playing = 0;
			Animates.SetInteger ("Animate", playing);
		}
	}
}
