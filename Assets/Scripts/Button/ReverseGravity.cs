using UnityEngine;
using System.Collections;

public class ReverseGravity : MonoBehaviour {

    [SerializeField]
    private float _gravityScale;
    [SerializeField]
    private Rigidbody2D[] _objects;

    private bool _upDown;

	public void Reverse()
	{
        if(_upDown)
        {
            _upDown = false;
            foreach (Rigidbody2D t in _objects)
            {
                t.gravityScale = _gravityScale;
            }
        }
        else
        {
            _upDown = true;
            foreach (Rigidbody2D t in _objects)
            {
                t.gravityScale = -_gravityScale;
            }
        }
        
	}
}