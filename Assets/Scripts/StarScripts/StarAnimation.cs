using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarAnimation : MonoBehaviour {

    [SerializeField]
    private List<GameObject> stars = new List<GameObject>();

    [SerializeField]
    private GameObject[] starsUI;

    private int tempCount = 0;

    void Start()
    {
        stars.AddRange(GameObject.FindGameObjectsWithTag("Star"));
    }

    void Update()
    {
        for (int i = 0; i < stars.Count; i++)
        {
            if (stars[i] == null)
            {
                stars.RemoveAt(i);
                starsUI[tempCount].GetComponent<StarRotate>().enabled = true;
                tempCount++;
            }
        }
    }
}
