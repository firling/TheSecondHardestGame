using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public event EventHandler<EventArgs> Collected; 

    public AudioSource audioSource;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player")) {
            OnCollected();
            Destroy(gameObject);
            audioSource.Play();
        }
    }

    private void OnCollected()
    {
        Collected?.Invoke(this, EventArgs.Empty);
    }
}