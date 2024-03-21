using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveSum : MonoBehaviour
{
    public GameObject wave;
    public LineRenderer lineRenderer;
    private LogicScript logic;

    private int points = 1000;
    private float amplitude1 = 0;
    private float amplitude2 = 0;
    private float frequency1 = 0;
    private float frequency2 = 0;
    private Vector2 xLimits = new Vector2(0, 20f);
    private float speed1 = 0;
    private float speed2 = 0;

    private bool isCalled1 = false;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        amplitude1 = logic.GetAmplitude1();
        frequency1 = logic.GetFrequency1();
        amplitude2 = logic.GetAmplitude2();
        frequency2 = logic.GetFrequency2();
        speed1 = logic.GetSpeed1();
        speed2 = logic.GetSpeed2();
        Draw();
    }

    private void Draw()
    {
        float xStart = xLimits.x;
        float Tau = 2 * Mathf.PI;
        float xFinish = xLimits.y;

        lineRenderer.positionCount = points;
        for (int currentPoint = 0; currentPoint < points; currentPoint++)
        {
            float progress = (float)currentPoint / (points - 1);
            float x = Mathf.Lerp(xStart, xFinish, progress);
            float y1 = amplitude1 * Mathf.Sin((Tau * frequency1 * x) + (Time.timeSinceLevelLoad * speed1));
            float y2 = amplitude2 * Mathf.Sin((Tau * frequency2 * x) + (Time.timeSinceLevelLoad * speed2));
            float y = y1 + y2;

            lineRenderer.SetPosition(currentPoint, new Vector3(x, y, 0));
        }
    }
}
