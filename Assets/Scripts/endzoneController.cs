using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endzoneController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject candies =  GameObject.Find("Candies");
        if (candies.transform.childCount == 0)
        {
            Debug.Log("Level Done");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("There are still some Candies left!");
        }
    }
}
