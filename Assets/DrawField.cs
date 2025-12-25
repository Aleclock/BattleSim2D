using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawField : MonoBehaviour
{
    public int segments = 50;
    public float radius = 2f;
    public float angleDegrees = 270f;

    void Awake()
    {
        LineRenderer line = GetComponent<LineRenderer>();
        line.positionCount = segments + 1;
        line.useWorldSpace = false;

        for (int i = 0; i <= segments; i++)
        {
            // Convert index to current angle in radians
            float progress = (float)i / segments;
            float currentAngle = Mathf.Deg2Rad * progress * angleDegrees;

            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;

            line.SetPosition(i, new Vector3(x, y, 0));
        }
    }
}