using UnityEngine;

public class ScaleAllDirections : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale += (Vector3.one * _speed * Time.deltaTime); 
    }
}
