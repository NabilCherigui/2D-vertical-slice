using UnityEngine;

public class RotateCircle : MonoBehaviour {

    private float _time;

    void Update ()
    {
        _time += Time.deltaTime;
        var x = Mathf.Cos (_time);
        var y = Mathf.Sin (_time);
        transform.position = new Vector2 (x, y + 1.24f);
    }
}