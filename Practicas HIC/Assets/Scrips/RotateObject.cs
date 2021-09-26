using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : Interactable
{
    public Vector3 rotationAxis;
    // Start is called before the first frame update
    public override void Interact()
    {
        base.Interact();
        transform.Rotate(rotationAxis,90f);
    }
}
