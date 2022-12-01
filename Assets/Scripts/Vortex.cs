using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vortex : MonoBehaviour
{
    public Transform vortex;
    public AudioWork _audioPeer;
    public float vortexSpeed, cameraDistance;


    // Update is called once per frame
    void FixedUpdate()
    {
        vortex.position = new Vector3(vortex.position.x, vortex.position.y, vortex.position.z + (Time.deltaTime * vortexSpeed));
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, vortex.position.z + cameraDistance);

        if (Input.GetKey(KeyCode.S) && vortexSpeed > 10)
        {
            vortexSpeed -= 0.2f;
        }
        if (Input.GetKey(KeyCode.W) && vortexSpeed < 500)
        {
            vortexSpeed += 0.2f;
        }
        if (Input.GetKey(KeyCode.R))
        {
            vortexSpeed = 80;
        }

    }
}


