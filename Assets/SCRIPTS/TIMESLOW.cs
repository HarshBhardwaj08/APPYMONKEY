using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIMESLOW : MonoBehaviour
{
    public float slowdownFactor = 0.5f;
    public KeyCode slowdownKey = KeyCode.R;
    public GameObject player; // Drag and drop the player GameObject here

    private bool isSlowed = false;
    private float originalTimeScale;

    private void Start()
    {
        originalTimeScale = Time.timeScale;
    }

    private void Update()
    {
        if (Input.GetKeyDown(slowdownKey))
        {
            if (!isSlowed)
            {
                isSlowed = true;
                Time.timeScale = slowdownFactor;

                // Disable player's rigidbody to prevent the slowdown effect on the player
                if (player != null)
                {
                    Rigidbody2D playerRigidbody = player.GetComponent<Rigidbody2D>();
                    if (playerRigidbody != null)
                    {
                        playerRigidbody.velocity = Vector2.zero;
                        playerRigidbody.simulated = false;
                    }
                }
            }
        }
        else if (Input.GetKeyUp(slowdownKey) && isSlowed)
        {
            isSlowed = false;
            Time.timeScale = originalTimeScale;

            // Enable player's rigidbody again
            if (player != null)
            {
                Rigidbody2D playerRigidbody = player.GetComponent<Rigidbody2D>();
                if (playerRigidbody != null)
                {
                    playerRigidbody.simulated = true;
                }
            }
        }
    }
}
