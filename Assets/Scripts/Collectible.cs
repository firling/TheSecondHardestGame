using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public event EventHandler<EventArgs> Collected; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player")) {
            OnCollected();
            Destroy(gameObject);
        }
    }

    private void OnCollected()
    {
        Collected?.Invoke(this, EventArgs.Empty);
    }
}