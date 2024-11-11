using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public int speed = 1;
    public Rigidbody2D myRigidbody;
    float speedY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedY = Input.GetAxisRaw("Vertical") * speed;
        myRigidbody.velocity = new Vector2(0,speedY);

    }
}
