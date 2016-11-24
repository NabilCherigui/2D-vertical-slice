using UnityEngine;
using System.Collections;

public class StarAnimation : MonoBehaviour {

    //private Vector3 Scale = transform.localScale;

    void OnEnable ()
    {
        gameObject.transform.localScale = new Vector3(0f, 0.5f, 0.5f);
        StartCoroutine(ScaleUp());
	}

    private IEnumerator ScaleUp()
    {
        //if(Scale.x < 0.5f)
       // {

       // }
        gameObject.transform.localScale += new Vector3(0.1f, 0f, 0f);
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ScaleUp());
    }
}
