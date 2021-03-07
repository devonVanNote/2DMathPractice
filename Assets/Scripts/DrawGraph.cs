using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    // Start is called before the first frame update
    public int size = 20;
    public int xMax = 100;
    public int yMax = 100;
    private Coords xStartPoint;
    private Coords xEndPoint;
    private Coords yStartPoint;
    private Coords yEndPoint;

    void Start()
    {
        SetAxisCoordinates();
        DrawAxes();
        MakeGraph();
    }

    private void SetAxisCoordinates()
    {
        xStartPoint = new Coords(xMax, 0);
        xEndPoint = new Coords(-xMax, 0);
        yStartPoint = new Coords(0, yMax);
        yEndPoint = new Coords(0, -yMax);
    }

    private void DrawAxes()
    {
        Coords.DrawLine(yStartPoint, yEndPoint, 1, Color.green);
        Coords.DrawLine(xStartPoint, xEndPoint, 1, Color.red);
    }

    private void MakeGraph()
    {
        int xOffset = (xMax / size) * size;
        int yOffset = (yMax / size) * size;

        for(int x = -xOffset; x <= xOffset; x+=size)
        {
            Coords start = new Coords(x, -yMax);
            Coords end = new Coords(x, yMax);
            Coords.DrawLine(start, end, 0.5f, Color.grey);
        }

        for(int y = -yOffset; y <= yOffset; y+=size)
        {
            Coords start = new Coords(-xMax, y);
            Coords end = new Coords(xMax, y);
            Coords.DrawLine(start, end, 0.5f, Color.grey);
        }
    }
}
