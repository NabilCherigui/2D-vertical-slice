using UnityEngine;
using System.Collections;

public class StarRotate : MonoBehaviour {

    [SerializeField]
    private float rotationSpeed;

    private bool complete = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(ScaleUp());
	}
    private IEnumerator ScaleUp()
    {
        while (!complete)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 179)
            {
                complete = true;
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
            yield return null;
        }
    }
}
