using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

//[CreateAssetMenu(fileName = "Sword", menuName = "Inventory/Equipment/Key")]

[CreateAssetMenu(fileName = "RustyKey", menuName = "Inventory/RustyKey")]
public class RustyKey : Item
{
     public GameObject prefabToSpawn; 
     private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        _player = FindObjectOfType<FirstPersonController>();

         Vector3 offset = new Vector3(1f, 1f, 1f);
        Instantiate(prefabToSpawn, _player.transform.position + offset, Quaternion.identity);  
    }
}