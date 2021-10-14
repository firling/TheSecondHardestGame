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

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        float translationX = Input.GetAxis("Horizontal");
        float translationY = Input.GetAxis("Vertical");

        Vector2 translation = new Vector2(translationX, translationY);

        m_body.velocity = translation * speed;

        if(translationX != 0)
        {
            m_renderer.flipX = translationX < 0;
        }
    }
}