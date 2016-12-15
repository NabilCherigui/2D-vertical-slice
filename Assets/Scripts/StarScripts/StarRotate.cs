using UnityEngine;
using System.Collections;

public class StarRotate : MonoBehaviour {

    [SerializeField]
    private float _rotationSpeed;

    private bool _complete = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(ScaleUp());
	}
    private IEnumerator ScaleUp()
    {
        while (!_complete)
        {
            transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 179)
            {
                _complete = true;
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
            yield return null;
        }
    }
}
