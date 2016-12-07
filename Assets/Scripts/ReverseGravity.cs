using UnityEngine;
using System.Collections;

public class ReverseGravity : MonoBehaviour {
	private Rigidbody2D _rigidBody;

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
                t.gravityScale = 0.4f;
            }
        }
        else
        {
            _upDown = true;
            foreach (Rigidbody2D t in _objects)
            {
                t.gravityScale = -0.4f;
            }
        }
        
	}
}