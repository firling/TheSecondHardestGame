using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager Instance;

    public EnemyManager Enemy { get; private set; }
    public PlayerManager Player { get; private set; }

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
        Playing = false;
        Enemy = GetComponent<EnemyManager>();
        Player = GetComponent<PlayerManager>();
    }
    

    public void StartGame()
    {
        Playing = true;
        Enemy.startAllEnemies();
        Player.startPlayer();
    }

    public void StopGame()
    {
        Playing = false;
        Player.stopPlayer();
    }
}
