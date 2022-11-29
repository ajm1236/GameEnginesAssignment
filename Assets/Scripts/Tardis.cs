using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tardis : MonoBehaviour
{
    [Range(0, 360)]
    public float rotSpeed;
    [Range(5, 100)]
    public float distance = 20;
    public Transform doctor;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotSpeed * Time.deltaTime, rotSpeed * Time.deltaTime, -(rotSpeed * Time.deltaTime));
        this.transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance;

        if (Input.GetKey(KeyCode.DownArrow) && distance > 2)
        {
            distance -= 0.1f;
        }

        if(Input.GetKey(KeyCode.UpArrow) && distance >= 0 && distance < 100)
        {
            distance += 0.1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotSpeed -= 0.3f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotSpeed += 0.3f;
        }
        if (Input.GetKey(KeyCode.R))
        {
            rotSpeed = 0;
            distance = 20;
        }
    }
}

