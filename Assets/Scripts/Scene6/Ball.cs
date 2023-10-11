using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 _additivePosition;
    public static event UnityAction<float> MoveBall;

    private void FixedUpdate()
    {
        transform.position += _additivePosition;

        if (transform.position.z == (int)transform.position.z)
        {
            MoveBall?.Invoke(transform.position.z);
        }
    }
}
