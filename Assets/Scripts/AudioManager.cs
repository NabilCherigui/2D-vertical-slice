using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public  class AudioManager : MonoBehaviour
{



    public AudioClip Star1;
    public AudioClip Star2;
    public AudioClip Star3;
    public AudioClip Swoosh1;
    public AudioClip Swoosh2;
    public AudioClip Click1;
    public AudioClip Click2;
    private AudioSource _audio1;
    private AudioSource _audio2;

    private void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        _audio1 = audios[0];
        _audio2 = audios[1];

    }

    public void PlaySound(AudioClip clip)
    {

        _audio1.clip = clip;
        _audio1.Play();

    }
    public void PlayStarSound(int number)
    {

        switch (number)
        {
            case 1:
                _audio2.clip = Star1;
                break;
            case 2:
                _audio2.clip = Star2;
                break;
            case 3:
                _audio2.clip = Star3;
                break;

        }
        _audio2.Play();
    }
}
