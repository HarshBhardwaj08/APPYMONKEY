using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bullet_speed;
    float destroyTime = 7f;
    MANGE_SCORE scoreing;


    void Start()
    {
        scoreing = GetComponent<MANGE_SCORE>();
        Invoke("DestroyObject", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        move();

    }

    private void move()
    {
        Vector3 temp = transform.position;
        temp.x += bullet_speed * Time.deltaTime;
        transform.position = temp;
    }

    void DestroyObject()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet hit an object with the "Destroyable" tag
        if (other.CompareTag("Enemy"))
        {
            // Destroy the object and the bullet
            Destroy(other.gameObject);
            Destroy(gameObject);
           
        }
    }

}