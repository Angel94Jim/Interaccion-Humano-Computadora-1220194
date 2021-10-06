using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ShowInventoryCanvas : MonoBehaviour
{
    void Start() 
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }


    void Update()
    {
            
        if(Input.GetKeyDown(KeyCode.Tab))
        {  
            GetComponent<Canvas>().enabled = true;
        }
            
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            GetComponent<Canvas>().enabled = false; 
        }
    }
}

