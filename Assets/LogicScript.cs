using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public float amplitude1 = 0;
    public float amplitude2 = 0;
    public float frequency1 = 0;
    public float frequency2 = 0;
    public float speed1 = 0;
    public float speed2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        amplitude1 = 2;
        amplitude2 = 2;
        frequency1 = 0.5f;
        frequency2 = 0.2f;
        speed1 = 1;
        speed2 = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float GetAmplitude1()
    {
        return amplitude1;
    }

    public float GetAmplitude2()
    {
        return amplitude2;
    }

    public float GetFrequency1()
    {
        return frequency1;
    }

    public float GetFrequency2()
    {
        return frequency2;
    }

    public float GetSpeed1()
    {
        return speed1;
    }

    public float GetSpeed2()
    {
        return speed2;
    }

    public void SetAmplitude1(float amplitude)
    {
        amplitude1 = amplitude;
    }

    public void SetAmplitude2(float amplitude)
    {
        amplitude2 = amplitude;
    }

    public void SetFrequency1(float frequency)
    {
        frequency1 = frequency;
    }

    public void SetFrequency2(float frequency)
    {
        frequency2 = frequency;
    }

    public void SetSpeed1(float speed)
    {
        speed1 = speed;
    }

    public void SetSpeed2(float speed)
    {
        speed2 = speed;
    }
}
