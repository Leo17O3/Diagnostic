using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Transform _target;

    private void LateUpdate()
    {
        transform.position = _target.position - _offset;
    }
}
