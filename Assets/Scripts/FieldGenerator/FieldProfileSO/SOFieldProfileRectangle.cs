using UnityEngine;

[CreateAssetMenu(fileName = "NewRectangleProfile", menuName = "SO/Fields/Rectangle")]
public class RectangleProfile : FieldProfile
{
    public Vector2 size = new Vector2(4, 2);
    public int rotationOffset = 0;

    public override Vector2[] GeneratePoints()
    {
        float w = size.x / 2;
        float h = size.y / 2;
        float angle = rotationOffset * Mathf.Deg2Rad;
        float cos = Mathf.Cos(angle);
        float sin = Mathf.Sin(angle);
        
        // Defined in a loop to close the shape
        Vector2[] basePoints = new Vector2[] {
            new Vector2(-w, -h), new Vector2(w, -h), 
            new Vector2(w, h), new Vector2(-w, h), new Vector2(-w, -h)
        };
        
        Vector2[] rotatedPoints = new Vector2[basePoints.Length];
        for (int i = 0; i < basePoints.Length; i++)
        {
            rotatedPoints[i] = new Vector2(
                basePoints[i].x * cos - basePoints[i].y * sin,
                basePoints[i].x * sin + basePoints[i].y * cos
            );
        }
        
        return rotatedPoints;
    }
}