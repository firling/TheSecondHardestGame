using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyController : MonoBehaviour
{

    public List<GameObject> positions = new List<GameObject>();

    private int index = 0;

    private Vector2 movePosition;

    //[Range(0, 10)]
    public float speed = 5f;
    
    void Awake()
    {

        if (positions.Count > 0)
        {
            movePosition = new Vector2(positions[index].transform.position.x, positions[index].transform.position.y);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (positions.Count == 0) return;
        
        Vector3 newPos = Vector3.MoveTowards(transform.position, movePosition, speed * Time.deltaTime);

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
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}