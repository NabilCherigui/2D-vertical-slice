using UnityEngine;
using System.Collections;

public class Eaten : MonoBehaviour
{
    [SerializeField]
    private SceneLoader sceneloader;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("jep");
        if(other.gameObject.CompareTag("Candy"))
        {
            sceneloader.LoadScene(0);
        }
    }
}
