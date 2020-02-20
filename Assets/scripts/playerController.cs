using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float rotateSpeed,speed=0;
    private float f = 0.0f;
    public Transform starShip;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        starShip.Translate(Vector3.up * speed * Time.deltaTime * 0.1f);
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            starShip.transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            starShip.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (speed>=0||speed<20)
            {
                    speed++;
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (speed >= 0 ||(speed<=20&&speed!=0))
            {
                speed--;
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
        }

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
