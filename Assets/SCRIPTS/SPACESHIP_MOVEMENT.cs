using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPACESHIP_MOVEMENT : MonoBehaviour
{
    public float movespeed;
    [SerializeField]float minY, maxY;

    [SerializeField] GameObject bullet;
    [SerializeField] Transform tunnet;
    float attack_time = 0.35f;
    float current_attack_time;
    bool canAttack;
   

    void Start()
    {
        current_attack_time = attack_time;
    }

    // Update is called once per frame
    void Update()
    {

        movePlayer();
        attack();
       
    }

    private void movePlayer()
    {
       if(Input.GetAxisRaw("Vertical")> 0f)
        {
            Vector3 temp = transform.position;
            temp.y += movespeed * Time.deltaTime;
            if (temp.y > maxY)
            { temp.y = maxY; }
            
            transform.position = temp;
        }
        else if(Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= movespeed * Time.deltaTime;
            if (temp.y < minY)
            { temp.y = minY; }
              transform.position = temp;
        }
    }

    void attack()
    {
        attack_time += Time.deltaTime;
        if(attack_time > current_attack_time)
        {
            canAttack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttack)
            {
                canAttack = false;
                attack_time = 0f;
                Instantiate(bullet, tunnet.position, Quaternion.identity);
                
            }
        }
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.tag == "Enemy")
        { 
            gameObject.SetActive(false); // Disable the player GameObject
            collision.gameObject.SetActive(false);
        }
        
    }

}
