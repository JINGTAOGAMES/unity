using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALLMOVE : MonoBehaviour
{
    public float BaseSpeed = 10;
    public float AddSpeed = 0;
    public Rigidbody2D RB;
    public bool Win;
    public float deadZone = -20;
    public float deadZone2 = 20;
    // Start is called before the first frame update
    void Start()
    {
        if (Win == true)
        {
            RB.velocity = Vector2.left * BaseSpeed;
        }

        else {
            RB.velocity = Vector2.right * BaseSpeed;

        }
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        if (transform.position.x > deadZone2)
        {
            Destroy(gameObject);
        }

    }
}
