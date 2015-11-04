using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Camera))]
public class DrawCameraBoundsInEditor : MonoBehaviour {
    Camera _camera;
    public bool show;
    void Awake(){
        SetSize();
    }
    void OnValidate(){
        SetSize();
    }
    void SetSize(){
        _camera = GetComponent<Camera>();
        _camera.orthographicSize = Config.CameraHeight;
    }
    void OnDrawGizmos(){
        if ( !show ) {
            return;
        }
        Vector2 size = Config.CameraSize;
        float width = size.x;
        float height = size.y;
        Vector2 v1 = new Vector2(-width, height);
        Vector2 v2 = new Vector2(width, height);
        Vector2 v3 = new Vector2(width, -height);
        Vector2 v4 = new Vector2(-width, -height);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(v1, v2);
        Gizmos.DrawLine(v2, v3);
        Gizmos.DrawLine(v3, v4);
        Gizmos.DrawLine(v4, v1);
	}
}
