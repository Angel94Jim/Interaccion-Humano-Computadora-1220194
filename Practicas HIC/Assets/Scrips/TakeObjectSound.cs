using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObjectSound : MonoBehaviour
{
    public bool insideInteractionZone = false;
    
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
        if (Input.GetKeyDown(KeyCode.E) && insideInteractionZone)
        {
            audioSource.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            insideInteractionZone= true;    
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            insideInteractionZone= false;  
        }
    }
}
