using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
