using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScaler : MonoBehaviour
{
    public Camera targetCamera;
    public float initialCameraSize = 5f;
    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Calculate how much the camera has zoomed
        float scaleRatio = targetCamera.orthographicSize / initialCameraSize;

        // Apply that ratio to the UI element
        transform.localScale = initialScale * scaleRatio;
    }
}
