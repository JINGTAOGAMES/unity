using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    public int speed = 10;
    public Rigidbody2D myRigidbodyTwo;
    float speedY2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedY2 = Input.GetAxisRaw("Vertical(Number)") * speed;
        myRigidbodyTwo.velocity = new Vector2(0, speedY2);

    }
}
