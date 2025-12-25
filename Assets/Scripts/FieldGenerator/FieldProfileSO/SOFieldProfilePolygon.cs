
using UnityEngine;

[CreateAssetMenu(fileName = "NewPolygonProfile", menuName = "SO/Fields/Polygon")]
public class PolygonProfile : FieldProfile
{
    public float radius = 2f;
    public int sides = 4;
    public int rotationOffset = 0;

    public override Vector2[] GeneratePoints()
    {
        Vector2[] points = new Vector2[sides + 1];
        for (int i = 0; i <= sides; i++)
        {
            float angle = (i * 360f / sides + rotationOffset) * Mathf.Deg2Rad;
            points[i] = new Vector2(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius);
        }
        return points;
    }
}