using UnityEngine;
using System.Collections;

[RequireComponent (typeof(RectTransform))]
[RequireComponent (typeof(Canvas))]
public class CanvasWorldSpaceWidthBehaviour : MonoBehaviour {
	void Awake(){
		UpdateWidth();
	}

	void OnValidate(){
		UpdateWidth();
    }

	void UpdateWidth(){
        Vector2 size = Config.CameraSize;
        RectTransform rectTransfrom = GetComponent<RectTransform>();
        rectTransfrom.sizeDelta = size * 2;
    }
}
