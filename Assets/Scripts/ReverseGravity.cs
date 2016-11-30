using UnityEngine;
using System.Collections;

public class ReverseGravity : MonoBehaviour {
	private Rigidbody2D rigidBody;

    [SerializeField]
    private Rigidbody2D[] objects;

    private bool UpDown;

	public void Reverse()
	{
        if(UpDown)
        {
            UpDown = false;
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].gravityScale = 1.8f;
            }
        }
        else
        {
            UpDown = true;
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].gravityScale = -0.2f;
            }
        }
        
	}
}