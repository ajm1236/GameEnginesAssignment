using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread : MonoBehaviour
{

    public AudioWork _audio;


    public float degree, scale;
    public int start;
    public int size;
    public int maxSize;

    private int number;
    private int currentSize;
    private TrailRenderer trail;

    public Vector2 SpreadCalc(float degrees, float scales, int numberOf)
    {
        float radius = scales * Mathf.Sqrt(numberOf);
        double ang = numberOf * (degrees * Mathf.Deg2Rad);

        float x = radius * (float)System.Math.Cos(ang);
        float y = radius * (float)System.Math.Sin(ang);

        Vector2 newVec = new Vector2(x, y);
        return newVec;
    }

    private Vector2 pos;

    void Awake()
    {

        trail = GetComponent<TrailRenderer>();
        number = start;
        transform.localPosition = SpreadCalc(degree, scale, number);

    }


    // Update is called once per frame
    void Update()
    {

        pos = SpreadCalc(degree, scale, number);
        transform.localPosition = new Vector3(pos.x, pos.y, 0);
        number++;

    }


}
