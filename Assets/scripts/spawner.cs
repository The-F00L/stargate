using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private int calCul;
    public GameObject asteroid;
    float randX,randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn=0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && calCul < 5)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-9, 9);
            randY = Random.Range(-9, 9);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(asteroid, whereToSpawn, Quaternion.identity);
            calCul++;
        }
    }
}
