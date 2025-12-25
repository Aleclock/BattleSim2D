using UnityEngine;

[CreateAssetMenu(fileName = "NewCircleProfile", menuName = "SO/Fields/Circle")]
public class CircleProfile : FieldProfile
{
    public float radius = 2f;
    public int segments = 50;
    public float angleDegrees = 270f;

    public override Vector2[] GeneratePoints()
    {
        Vector2[] points = new Vector2[segments + 1];
        for (int i = 0; i <= segments; i++)
        {
            float angle = (i * angleDegrees / segments) * Mathf.Deg2Rad;
            points[i] = new Vector2(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius);
        }
        return points;
    }
}