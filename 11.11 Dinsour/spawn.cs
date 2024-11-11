using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour  
{
    public GameObject cacti1;
    public GameObject cacti2;
    public GameObject cacti3;
    public GameObject bird;
    private float timer = 10;
    private float spawnrate = 30;
    public float ramdomnumber;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time/5;
    }

    // Update is called once per frame
    void Update() 
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime * 10; ;
        }
        else
        {
            SpawnBlocks();
            timer = 10 + Time.time/5 - startTime;  ;
        }
    }

    void SpawnBlocks() 
    {
        ramdomnumber = UnityEngine.Random.Range(1, 10);
        if ( ramdomnumber == 1 ) {Instantiate(cacti1, new Vector3(transform.position.x,  -3), transform.rotation); }
        else if (ramdomnumber == 7) { Instantiate(cacti1, new Vector3(transform.position.x, -3), transform.rotation); }
        else if ( ramdomnumber == 2 ) { Instantiate(cacti2, new Vector3(transform.position.x, -3), transform.rotation); }
        else if (ramdomnumber == 8) { Instantiate(cacti2, new Vector3(transform.position.x, -3), transform.rotation); }
        else if (ramdomnumber == 3) { Instantiate(cacti3, new Vector3(transform.position.x, -3), transform.rotation); }
        else if (ramdomnumber == 9) { Instantiate(cacti3, new Vector3(transform.position.x, -3), transform.rotation); }
        else if (ramdomnumber == 4) { Instantiate(bird, new Vector3(transform.position.x, -2), transform.rotation); }
        else if (ramdomnumber == 5) { Instantiate(bird, new Vector3(transform.position.x, -3), transform.rotation); }
        else if (ramdomnumber == 6) { Instantiate(bird, new Vector3(transform.position.x, -4), transform.rotation); }
    }

}
