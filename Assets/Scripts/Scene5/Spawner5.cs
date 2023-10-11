using UnityEngine;

public class Spawner5 : MonoBehaviour
{
    [SerializeField] private KeyCode _keyCode;

    private void Update()
    {
        if (Input.GetKeyDown(_keyCode))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = transform.position;
            cube.AddComponent<Rigidbody>();
        }
    }
}
