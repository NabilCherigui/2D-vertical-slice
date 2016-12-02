using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("Star"))
        {
            Destroy(other.gameObject);
        }
	}
}