using UnityEngine;

public class RotateCircle : MonoBehaviour {

    [Range(1, 2)]
    [SerializeField]
    private float rotationOffset = 1;

    private float _time;

    void Update ()
    {
        _time += Time.deltaTime;
        var x = Mathf.Cos (_time) * rotationOffset;
        var y = Mathf.Sin (_time) * rotationOffset;
        transform.position = new Vector2 (x, y + 1.24f);
    }
}