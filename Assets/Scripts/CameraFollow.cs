using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _target;
    [SerializeField] private float smoothSpeed = 0.125f;
    public Vector3 _offset;

    // tam olmadı ayarla.
    private void LateUpdate() {

        Vector3 desiredPosition = _target.position + _offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }

}
