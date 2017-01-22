using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDJ : MonoBehaviour
{
    public AudioClip[] tracks = new AudioClip[5];
    AudioSource dj;

	// Use this for initialization
	void Start ()
    {
        dj = GetComponent<AudioSource>();
        PlayRandom();
	}

    void Update()
    {
        // super secret track switching
        if (Input.GetKeyDown(KeyCode.O) && Input.GetKeyDown(KeyCode.K))
        {
            dj.Stop();
            PlayRandom();
        }
    }

    void PlayRandom()
    {
        dj.PlayOneShot(tracks[Random.Range(0, tracks.Length)]);
    }
}
