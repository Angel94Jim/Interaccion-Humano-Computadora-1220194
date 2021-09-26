using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : Interactable
{
    public float moveSpeed=10f;
    // Start is called before the first frame update
    public override void Interact()
    {
        base.Interact();
        update();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void update()
    {
        transform.Translate(new Vector3(0, 0, 1000) * moveSpeed * Time.deltaTime);
    }
}
