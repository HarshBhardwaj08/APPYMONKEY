using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY_SCRIPTS : MonoBehaviour
{
    public float movespeed;
    [SerializeField] float minY, maxY;
    MANGE_SCORE mange_score;
    public int score = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x -= movespeed* Time.deltaTime;
        transform.position = temp;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet hit an object with the "Destroyable" tag
        if (other.CompareTag("Player"))
        {
            // Destroy the object and the bullet
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
    }
    private void OnDestroy()
    {
        if (mange_score != null)
        {
            mange_score.IncreaseScore(score);
        }
    }
}
