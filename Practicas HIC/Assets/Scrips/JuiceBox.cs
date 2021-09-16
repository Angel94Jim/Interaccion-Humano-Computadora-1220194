using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceBox : Interactable
{
    private AudioSource audioSource;
    public AudioClip[] clips;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        base.Interact();
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}