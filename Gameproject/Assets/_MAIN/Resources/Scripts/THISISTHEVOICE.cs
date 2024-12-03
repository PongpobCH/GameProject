using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THISISTHEVOICE : MonoBehaviour
{
    [SerializeField] public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = audioClip;

        audioSource.Play();
    }
}
