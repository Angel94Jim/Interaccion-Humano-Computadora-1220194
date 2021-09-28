using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStepSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
         audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        if (audioSource != null)
        {
            audioSource.Play();
        }

        

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
