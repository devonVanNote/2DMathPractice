using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    private Coords xStartPoint;
    private Coords xEndPoint;
    private Coords yStartPoint;
    private Coords yEndPoint;
    private Camera camera;

    private List<Coords> ariesStarSignPoints = new List<Coords>()
    {
        new Coords(0,0),
        new Coords(-3, 15),
        new Coords(-25, 30),
        new Coords(-80, 40)
    };

    void Start()
    {
        camera = GameObject.FindObjectOfType<Camera>();
        SetAxisCoordinates();
        DrawAxes();
        DrawAriesStarSign();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetAxisCoordinates()
    {
        xStartPoint = new Coords(GetXAxis(), 0);
        xEndPoint = new Coords((GetXAxis() * -1), 0);
        yStartPoint = new Coords(0, camera.orthographicSize);
        yEndPoint = new Coords(0, (camera.orthographicSize * -1));
    }

    private void DrawAxes()
    {
        Coords.DrawLine(yStartPoint, yEndPoint, 1, Color.green);
        Coords.DrawLine(xStartPoint, xEndPoint, 1, Color.red);
    }

    private void DrawAriesStarSign()
    {
        for(int i = 0; i < ariesStarSignPoints.Count - 1; i++)
        {
            Coords.DrawLine(ariesStarSignPoints[i], ariesStarSignPoints[i+1], 1, Color.white);
        }
    }

    private void DrawGraph()
    {
        for(int i = 1; i <= 10; i++)
        {
            Coords y = new Coords(0, (camera.orthographicSize * -1 + (i + 20)));
            Coords x = new Coords((GetXAxis() * -1), 0);
            Coords.DrawLine(x, y, 1, Color.gray);
        }
    }

    private float GetXAxis()
    {
        return ((float)Screen.width / (float)Screen.height) * camera.orthographicSize;
    }
}
