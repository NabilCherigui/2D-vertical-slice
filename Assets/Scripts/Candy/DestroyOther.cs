using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour
{
    [SerializeField]
    private string _tagOfObject;

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag(_tagOfObject))
        {
            Destroy(other.gameObject);
        }
	}
}