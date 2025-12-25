using System;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawField : MonoBehaviour
{
    [SerializeField] private FieldProfile profile;
    [SerializeField] private Material fieldMaterial;
    private LineRenderer line;

    public Action<LineRenderer> OnLineUpdated;

    void Start()
    {
        RefreshField();
    }

    public void RefreshField()
    {
        if (profile == null) return;
        line = GetComponent<LineRenderer>();

        Vector2[] points = profile.GeneratePoints();

        // Update Line
        line.positionCount = points.Length;
        for (int i = 0; i < points.Length; i++)
            line.SetPosition(i, new Vector3(points[i].x, points[i].y, 0));
            
        line.material = fieldMaterial;

        // Update Collider
        OnLineUpdated?.Invoke(line);
        Debug.Log("Field refreshed with " + points.Length + " points.");
    }
    
    private void OnDrawGizmos() { 
        RefreshField(); 
    }
}