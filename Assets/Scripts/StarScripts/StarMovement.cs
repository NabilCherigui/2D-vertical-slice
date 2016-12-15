using UnityEngine;
using System.Collections;

public class StarMovement : MonoBehaviour {

    [SerializeField]
    private float _steps;
	
	void Start ()
    {
        StartCoroutine("ChangePosition");
    }
    IEnumerator ChangePosition ()
    {
        for (int i = 0; i < 25; i++)
        {
            transform.position += new Vector3(0, _steps, 0);
            yield return new WaitForSeconds(0.05f);
        }
        _steps *= -1;
        StartCoroutine("ChangePosition");
    }
}
