using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(EdgeCollider2D))]
public class LineColliderSync : MonoBehaviour
{
    void Start()
    {
        LineRenderer line = GetComponent<LineRenderer>();
        EdgeCollider2D edge = GetComponent<EdgeCollider2D>();

        // 1. Get positions from the Line Renderer
        Vector3[] linePoints = new Vector3[line.positionCount];
        line.GetPositions(linePoints);

        // 2. Convert Vector3[] to List<Vector2> for the Collider
        List<Vector2> edgePoints = new List<Vector2>();
        foreach (Vector3 point in linePoints)
        {
            edgePoints.Add(new Vector2(point.x, point.y));
        }

        // 3. Update the Edge Collider
        edge.SetPoints(edgePoints);
    }
}