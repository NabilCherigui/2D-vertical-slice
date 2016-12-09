using UnityEngine;
using System.Collections;

public class ReverseGravity : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D candy;

    [SerializeField]
    private float gravityScale;

    [SerializeField]
    private Rigidbody2D[] objects;

    private bool UpDown;

	public void Reverse()
	{
        if(UpDown)
        {
            UpDown = false;
            candy.gravityScale = 1;
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].gravityScale = gravityScale;
            }
        }
        else
        {
            UpDown = true;
            candy.gravityScale = -1;
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].gravityScale = -gravityScale;
            }
        }
        
	}
}