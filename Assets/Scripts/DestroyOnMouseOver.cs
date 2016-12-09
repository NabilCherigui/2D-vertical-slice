using UnityEngine;
using System.Collections;

public class DestroyOnMouseOver : MonoBehaviour {

	void OnMouseOver()
    {
        if(Input.GetMouseButton(1) || Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
}
