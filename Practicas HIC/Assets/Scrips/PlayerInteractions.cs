using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
[RequireComponent(typeof(PlayerInput))]
#endif

public class PlayerInteractions : MonoBehaviour
{
    private StarterAssetsInputs _input;
    private Interactable _interactable;

    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

  
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            _interactable = other.GetComponent<Interactable>();
            Debug.Log("Entró a el area");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            _interactable = null;
            Debug.Log("Salió del area");
        }
    }
}

