using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnSpeed;
    private float _currentTime;

    private void LateUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnSpeed)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = transform.position;
            cube.AddComponent<Rigidbody>();

            _currentTime = 0f;
        }
    }
}
