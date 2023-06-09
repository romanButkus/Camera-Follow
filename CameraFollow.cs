using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _cameraPosition;
    [SerializeField] private float x, y, z;

    void LateUpdate()
    {
        transform.position = new Vector3(_cameraPosition.position.x + x, _cameraPosition.position.y + y, z);
    }
}
