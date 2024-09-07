using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObject : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void Update()
    {
        if (!audioSource.isPlaying) Destroy(gameObject);
    }
}