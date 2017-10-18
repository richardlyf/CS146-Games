using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public float jumpForce = 10f;
    public float topSpeed = 10f;
    public float jumpWaitPeriod = 5f;

    public GameObject jumpSound;

    bool jumpReady = true;
    float jumpTimer = 0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w") && jumpReady && SceneManager.GetActiveScene().buildIndex != 1)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            jumpSound.SetActive(false);
            jumpSound.SetActive(true);
            jumpReady = false;
            jumpTimer = jumpWaitPeriod;
        }

        if (!jumpReady)
        {
            jumpTimer -= Time.deltaTime;
            if(jumpTimer < 0)
            {
                jumpReady = true;
                jumpTimer = 0f;
            }
        }

        //make sure the speeder doesn't go tooo fast
        if (rb.velocity.magnitude > topSpeed)
        {
            rb.velocity = rb.velocity.normalized * topSpeed;
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GamerManager>().EndGame();
        }

    }

    public float getJumpTimer()
    {
        return jumpTimer;
    }
}