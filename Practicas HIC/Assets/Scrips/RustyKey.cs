using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "RustyKey", menuName = "Inventory/RustyKey")]
public class RustyKey : Item
{
   
    private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        // respawn del objeto...
    }
}