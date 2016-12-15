using UnityEngine;
using System.Collections;

public class IgnoreLayer : MonoBehaviour {
    [SerializeField]
    private int[] _otherLayer;
    [SerializeField]
    private int _mainLayer;

	void Start ()
    {
        for (int i = 0; i < _otherLayer.Length; i++)
        {
            Physics2D.IgnoreLayerCollision(_otherLayer[i], _mainLayer);
        }
	}
}
