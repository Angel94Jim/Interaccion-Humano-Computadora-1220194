using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : Interactable
{
    public Vector3 forceVector;
    private Rigidbody rb;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public override void Interact()
    {
        base.Interact();
        update();
    }

    void update()
    {
        rb.AddForce(forceVector, ForceMode.Force);
    }
}