using UnityEngine;

public class Spawner7 : MonoBehaviour
{
    [SerializeField] private float _spawnSpeed;
    [SerializeField] private Transform[] _spawnPoints;
    private float _currentTime;

    private void LateUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnSpeed)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;
            cube.AddComponent<Rigidbody>();

            _currentTime = 0f;
        }
    }
}
