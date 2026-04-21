using UnityEngine;

public class LiveCube : MonoBehaviour
{
    private float _speedMove = 1f;
    private float _speedRotate = 20f;
    private float _speedScale = 0.2f;

    void Update()
    {
        transform.Translate(Vector3.fwd * _speedMove * Time.deltaTime);

        transform.Rotate(Vector3.up * _speedRotate * Time.deltaTime);

        transform.localScale += (Vector3.one * _speedScale * Time.deltaTime);
    }
}
