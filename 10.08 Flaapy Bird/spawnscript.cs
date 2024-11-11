using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnscript : MonoBehaviour
{
    public GameObject Pipers;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightOffset = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            SpawnPipe();
            timer = 0;
        }
        void SpawnPipe() 
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;



            Instantiate(Pipers, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
        }

    }
}