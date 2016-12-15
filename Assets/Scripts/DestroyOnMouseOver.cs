using UnityEngine;
using System.Collections;

public class DestroyOnMouseOver : MonoBehaviour {

	void OnMouseOver()
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
}
