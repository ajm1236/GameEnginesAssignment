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

        if (Input.GetKeyDown(KeyCode.DownArrow) && distance > 5)
        {
            distance -= 5;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && distance >= 0 && distance < 100)
        {
            distance += 5;
        }
    }
}

