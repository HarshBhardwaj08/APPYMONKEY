using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bullet_speed;
    float destroyTime = 7f;
    MANGE_SCORE scoreing;
    int value = 10;


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

   void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            MANGE_SCORE.instance.IncreaseScore(value);
         }
    }


}