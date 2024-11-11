using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public logicscript logic;
    public bool birdisAlive = true;
    //Learn from https://www.youtube.com/watch?v=XtQMytORBmM&t=316s
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "Silly";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&birdisAlive)
        {
           myRigidbody.velocity = Vector2.up * flapstrength; 
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
      birdisAlive = false;
    }
}
