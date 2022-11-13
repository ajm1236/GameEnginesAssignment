using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread : MonoBehaviour
{
    public float degree, scale;
    public int start;
    public int size;
    public int maxSize;

    //lerp stuff
    public bool lerp;
    public float interval;
    private bool isLerp;
    public Vector3 startPos, endPos;
    private float timeStart;

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

    void Lerping()
    {
        isLerp = true;
        timeStart = Time.time;
        pos = SpreadCalc(degree, scale, number);
        startPos = this.transform.localPosition;
        endPos = new Vector3(pos.x, pos.y, 0);
    }

    void Awake()
    {
        trail = GetComponent<TrailRenderer>();
        number = start;
        transform.localPosition = SpreadCalc(degree, scale, number);
        if (lerp)
        {
            Lerping();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (lerp)
        {
            if (isLerp)
            {
                float sinceStart = Time.time - timeStart;
                float perComplete = sinceStart / interval;
                transform.localPosition = Vector3.Lerp(startPos, endPos, perComplete);
                if (perComplete >= 0.99f)
                {
                    transform.localPosition = endPos;
                    number += size;
                    currentSize++;
                    if(currentSize <= maxSize)
                    {
                        Lerping();
                    }
                    else
                    {
                        isLerp = false;
                    }
                }
            }
        }
        else
        {
            pos = SpreadCalc(degree, scale, number);
            transform.localPosition = new Vector3(pos.x, pos.y, 0);
            number++;
        }
    }
}
