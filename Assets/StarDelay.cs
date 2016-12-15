using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarDelay : MonoBehaviour {

    [SerializeField]
    private List<Animator> _stars = new List<Animator>();
    private float _randomNumber;

    void Start()
    {
        StartCoroutine(StartAnim());
    }

    private IEnumerator StartAnim ()
    {
        for (int i = 0; i < _stars.Count; i++)
        {
            yield return new WaitForSeconds(Random.Range(0, 1.1f));
            _stars[i].enabled = true;
        }
	}
}
