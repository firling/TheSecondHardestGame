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
            String name = SceneManager.GetActiveScene().name;
            String level = name.Substring(name.IndexOf("_")+1);
            int nextLevel = int.Parse(level) + 1;
            if (nextLevel <= SceneManager.sceneCountInBuildSettings) {
                SceneManager.LoadScene("level_" + nextLevel);
            } else {
                Debug.Log("Game Finished");
            }
        }
        else
        {
            // TODO - END THE GAME
            Debug.Log("There are still some Candies left!");
        }
    }
}
