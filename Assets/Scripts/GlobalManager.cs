using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{

    private bool created = false;

    void Awake()
    {  
        if (!created) {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        } else {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
