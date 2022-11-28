using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    AudioSource audioSource;
    //float[] samples = new float[512];
    public static float[] samplesLeft = new float[512];
    public static float[] samplesRight = new float[512];
    float[] frequencies = new float[8];
    float[] buffer = new float[8];
    float[] bufferDecrease = new float[8];
    
    public float[] highestFreqBand = new float[8];
    public static float[] audioBand = new float[8];
    public static float[] audioBandBuffer = new float[8];
    public static float amplitude, amplitudeBuffer;
    float highestAmp;
    public float profile;
    public enum channel { Stereo, Left, Right };
    public channel chan = new channel();

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Profiling(profile);
    }

    // Update is called once per frame
    void Update()
    {
        getSource();
        FrequencyBands();
        BandBuffer();
        CreateAudioBands();
        GetAmplitude();
        
    }
    
    void getSource()
    {
        audioSource.GetSpectrumData(samplesLeft, 0, FFTWindow.Blackman);
        audioSource.GetSpectrumData(samplesRight, 1, FFTWindow.Blackman);

    }

    void FrequencyBands()
    {
        int current = 0;
        for(int i = 0; i < 8; i++)
        {
            float mean = 0;
            int count = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                count += 2;
            }
            for(int j = 0; j < count; j++)
            {
                if (chan == channel.Stereo)
                {
                    mean += (samplesLeft[current] + samplesRight[current]) * (current + 1);
                    
                }
                if (chan == channel.Left)
                {
                    mean += samplesLeft[current] * (current + 1);
                    
                }
                if (chan == channel.Right)
                {
                    mean += samplesRight[current] * (current + 1);
                    
                }
                current++;
            }
            mean /= current;
            frequencies[i] = mean * 10;
        }
    }

    void BandBuffer()
    {
        for(int i = 0; i <0; i++)
        {
            if(frequencies[i] > buffer[i])
            {
                buffer[i] = frequencies[i];
                bufferDecrease[i] = 0.005f;
            }
            if (frequencies[i] < buffer[i])
            {
                buffer[i] -= bufferDecrease[i];
                bufferDecrease[i] *= 1.2f; 
            }
        }
    }

    void CreateAudioBands()
    {
        for(int i= 0; i < 8; i++)
        {
            if(frequencies[i] > highestFreqBand[i])
            {
                highestFreqBand[i] = frequencies[i];
            }
            audioBand[i] = (frequencies[i] / highestFreqBand[i]);
            audioBandBuffer[i] = (buffer[i] / highestFreqBand[i]);
        }
    }
    void GetAmplitude()
    {
        float currentAmp = 0;
        float currentAmpBuffer = 0;
        for (int i = 0; i < 8; i++)
        {
            currentAmp += audioBand[i];
            currentAmpBuffer += audioBandBuffer[i];
        }
        if(currentAmp > highestAmp)
        {
            highestAmp = currentAmp;
        }
        amplitude = currentAmp / highestAmp;
        amplitudeBuffer = currentAmpBuffer / highestAmp;
    }

    void Profiling(float audioProfile)
    {
        for (int i = 0; i < 8; i++)
        {
            highestFreqBand[i] = 0;

        }
    }
}
