using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vortex : MonoBehaviour
{
    public Transform vortex;
    public float vortexSpeed, cameraDistance;


    // Update is called once per frame
    void Update()
    {
        vortex.position = new Vector3(vortex.position.x, vortex.position.y, vortex.position.z + (Time.deltaTime * vortexSpeed));
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, vortex.position.z + cameraDistance);
        if(Input.GetKey(KeyCode.A))
        {
            vortex.position = new Vector3(vortex.position.x + 0.5f, vortex.position.y + 0.5f);
        }
    }
}


