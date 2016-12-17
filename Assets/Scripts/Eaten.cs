using UnityEngine;
using System.Collections;

public class Eaten : MonoBehaviour
{
    [SerializeField]
    private SceneLoader _sceneloader;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Candy"))
        {
            _sceneloader.LoadScene(0);
        }
    }
}
