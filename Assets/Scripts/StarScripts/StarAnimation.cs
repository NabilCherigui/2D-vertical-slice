using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarAnimation : MonoBehaviour {
    [SerializeField] private AudioManager _adioManager;
    private List<GameObject> _stars = new List<GameObject>();

    [SerializeField]
    private GameObject[] _starsUI;

    private int tempCount = 0;

    void Start()
    {
        _stars.AddRange(GameObject.FindGameObjectsWithTag("Star"));
    }

    void Update()
    {
        for (int i = 0; i < _stars.Count; i++)
        {
            if (_stars[i] == null)
            {

                _stars.RemoveAt(i);
                _starsUI[tempCount].GetComponent<StarRotate>().enabled = true;
                tempCount++;
                _adioManager.PlayStarSound(tempCount);
            }
        }
    }
}
