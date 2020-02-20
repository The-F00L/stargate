using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float speed;
    public Transform station;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(1, 100);
        station.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
