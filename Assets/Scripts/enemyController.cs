using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private Rigidbody2D m_body;

    private SpriteRenderer m_renderer;

    public List<GameObject> positions = new List<GameObject>();

    private int index = 0;

    private Vector2 movePosition;

    //[Range(0, 10)]
    public float speed = 4f;

    void Awake()
    {
        m_body = GetComponent<Rigidbody2D>();
        m_renderer = GetComponent<SpriteRenderer>();

        if (positions.Count > 0)
        {
            movePosition = new Vector2(positions[index].transform.position.x, positions[index].transform.position.y);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 newPos = Vector2.MoveTowards(transform.position, movePosition, speed * Time.deltaTime);

        UpdatePosition();

        transform.position = newPos;
    }

    void UpdatePosition()
    {
        if (movePosition != (Vector2) transform.position) return;
        
        if (index+1 < positions.Count)
        {
            index++;
        }
        else
        {
            index = 0;
        }
        
        movePosition = new Vector2(positions[index].transform.position.x, positions[index].transform.position.y);
    }
}