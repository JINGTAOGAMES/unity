using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public int jumphigh = 10;
    public int downlow = 5;
    public Rigidbody2D RB;
    public logic logic;
    public Animator animator;
    public BoxCollider2D Stand;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < -3)
        {
            RB.velocity = Vector2.up * jumphigh;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            RB.velocity = Vector2.down * downlow;
            animator.SetBool("Skate", true);
            Stand.enabled = false;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Skate", false);
            Stand.enabled = true;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.gameOver();
    }
}
