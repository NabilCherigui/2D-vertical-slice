using UnityEngine;
using System.Collections;

public class StarCounter : MonoBehaviour {

	[SerializeField]
	private GameObject[] _Stars;
	private int _count;
	private int _oldCount;

	void Update ()
	{
		_count = GameObject.FindGameObjectsWithTag ("Star").Length;
        if (_count < _oldCount)
        {
            _Stars[_count].SetActive(true);
        }
		_oldCount = _count;
	}
}
