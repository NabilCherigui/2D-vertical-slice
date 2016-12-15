using UnityEngine;

public class RotateCircle : MonoBehaviour {

    [Range(1, 2)]
    [SerializeField]
    private float _rotationOffset = 1.233f;

    private float _time;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        _time += Time.deltaTime;
        var x = Mathf.Cos (_time) * _rotationOffset;
        var y = Mathf.Sin (_time) * _rotationOffset;
        _rigidBody.velocity = new Vector2 (x, y);
    }
}