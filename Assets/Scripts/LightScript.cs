using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light flash;
    public float rotationSpeed = 45f;
    public float flashSpeed = 0.5f;

    void Start()
    {
        StartCoroutine(RotateLight());
        StartCoroutine(FlashLight());
    }

    IEnumerator RotateLight()
    {
        // Loop forever
        while (true)
        {

            flash.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator FlashLight()
    {
        // Loop forever
        while (true)
        {
            flash.enabled = true;
            yield return new WaitForSeconds(flashSpeed);
            flash.enabled = false;
            yield return new WaitForSeconds(flashSpeed);
        }
    }
}