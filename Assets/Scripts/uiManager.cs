using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    private gameManager m_Game;
    public Button startGame;
    void Awake()
    {
        m_Game = gameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(m_Game.Playing);
        // startGame.gameObject.SetActive(!m_Game.Playing);
    }
}
