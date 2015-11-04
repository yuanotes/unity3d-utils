using UnityEngine;
using System.Collections;

public static class Config {
    public static float CameraHeight = 160;
    public static Vector2 CameraSize = new Vector2(CameraWidth, CameraHeight);
    public static float CameraWidth {
        get {
            Camera.main.orthographicSize = CameraHeight;
            float width = CameraHeight * Camera.main.aspect;
            return width;
        }
    }
}
