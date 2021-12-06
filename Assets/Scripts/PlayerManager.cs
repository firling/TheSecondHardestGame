using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private playerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = UnityEngine.Object.FindObjectsOfType<playerController>()[0] ;
    }

    public void startPlayer() {
        player.setCanMove(true);
    }

    public void stopPlayer() {
        player.setCanMove(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
