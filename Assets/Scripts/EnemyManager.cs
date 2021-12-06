using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    private enemyController[] m_enemies;
    // Start is called before the first frame update
    void Start()
    {
        m_enemies = UnityEngine.Object.FindObjectsOfType<enemyController>() ;
    }

    public void startAllEnemies() {
        foreach(enemyController EC in m_enemies) {
            EC.startMoving();
        }
    }
    public void stopAllEnemies() {
        foreach(enemyController EC in m_enemies) {
            EC.stopMoving();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
