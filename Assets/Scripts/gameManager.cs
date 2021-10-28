using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager Instance;
    public bool Playing { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        Playing = true;
    }

    public void StopGame()
    {
        Playing = false;
    }
}
