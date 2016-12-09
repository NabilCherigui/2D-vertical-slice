using UnityEngine;

public class RotateCircle : MonoBehaviour {

    [Range(1, 2)]
    [SerializeField]
    private float _rotationOffset = 1.233f;

    private float _time;

    void Update ()
    {
        _time += Time.deltaTime;
        var x = Mathf.Cos (_time) * _rotationOffset;
        var y = Mathf.Sin (_time) * _rotationOffset;
        transform.position = new Vector2 (x, y + 1.24f);
    }
}