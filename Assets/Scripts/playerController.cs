using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D m_body;

    private SpriteRenderer m_renderer;

    //[Range(0, 10)]
    public float speed = 4f;

    void Awake()
    {
        m_body = GetComponent<Rigidbody2D>();
        m_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0;
        float y = 0;
        if (Input.GetKey(KeyCode.Z))
        {
            y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            y -= 1;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 1;
        }
        
        Vector2 translation = new Vector2(x, y);
        
        m_body.velocity = translation * speed;
    }
}