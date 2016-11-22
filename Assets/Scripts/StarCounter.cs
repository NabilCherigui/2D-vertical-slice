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
		for (int i = 0; i < _Stars.Length; i++)
		{
			if(_count < _oldCount)
			{
				_Stars [i].SetActive (true);
				_oldCount = _count;
			}
		}
		_oldCount = _count;
	}
}
