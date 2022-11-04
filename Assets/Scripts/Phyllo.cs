using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phyllo : MonoBehaviour
{
    public GameObject sphere;
    public float degree, scale;
    public int number;
    public float sphereScale;
    public Vector2 PhylloCalc(float degrees, float scales, int numberOf)
    {
        float radius = scales * Mathf.Sqrt(numberOf);
        double ang = numberOf * (degrees * Mathf.Deg2Rad);

        float x = radius * (float)System.Math.Cos(ang);
        float y = radius * (float)System.Math.Sin(ang);

        Vector2 newVec = new Vector2(x, y);
        return newVec;
    }

    private Vector2 phylloPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            phylloPos = PhylloCalc(degree, scale, number);
            GameObject sphereInst = (GameObject)Instantiate(sphere);
            sphereInst.transform.position = new Vector3(phylloPos.x, phylloPos.y, 0);
            sphereInst.transform.localScale = new Vector3(sphereScale, sphereScale, sphereScale);
            number++;
        }
    }
}
