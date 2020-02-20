using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reback : MonoBehaviour
{
    public Transform player;
    public float maxdistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) >= maxdistance)
        {
            player.position = -player.position;
            
        }
    }
}
