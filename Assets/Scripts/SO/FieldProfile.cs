using UnityEngine;

public abstract class FieldProfile : ScriptableObject
{
    public abstract Vector2[] GeneratePoints();
}