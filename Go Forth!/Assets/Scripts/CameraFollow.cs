using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 axis_offset;

    // Called immediately after Update for smooth movement
    private void LateUpdate()
    {
        transform.position = playerTransform.position + axis_offset;
    }
}
