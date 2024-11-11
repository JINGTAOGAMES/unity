using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ball;
    public GameObject ball1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }
    public void SpawnBall()
    {
        Instantiate(ball);
    }

    public void SpawnBall1()
    {
        Instantiate(ball1);
    }
    // Update is called once per frame
    void Update()
    {

    }
}




  
