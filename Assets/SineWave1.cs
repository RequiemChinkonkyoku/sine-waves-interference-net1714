using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave1 : MonoBehaviour
{
    public GameObject wave;
    public LineRenderer lineRenderer;
    private LogicScript logic;

    private int points = 1000;
    private float amplitude = 0;
    private float frequency = 0;
    private Vector2 xLimits = new Vector2(0, 20f);
    private float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        amplitude = logic.GetAmplitude1();
        frequency = logic.GetFrequency1();
        speed = logic.GetSpeed1();
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
            float y = amplitude * Mathf.Sin((Tau * frequency * x) + (Time.timeSinceLevelLoad * speed));

            lineRenderer.SetPosition(currentPoint, new Vector3(x, y, 0));
        }
    }
}
