using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour
{
    [SerializeField]
    private string tagOfObject;

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag(tagOfObject))
        {
            Destroy(other.gameObject);
        }
	}
}