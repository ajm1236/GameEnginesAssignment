using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tardis : MonoBehaviour
{
    [Range(0, 360)]
    public float rotSpeed;
<<<<<<< Updated upstream
=======
    [Range(0, 100)]
>>>>>>> Stashed changes
    public float distance = 20;
    public Transform doctor;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
        this.transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance;
    }
}

