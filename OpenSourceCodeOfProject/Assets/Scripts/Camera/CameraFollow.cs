using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;
    public Vector3 offset;
    
    void LateUpdate()
    {
        transform.position = followTransform.position + offset;
    }
}
