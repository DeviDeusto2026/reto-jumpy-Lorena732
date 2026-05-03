using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float offsetY = 5f;

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            target.position.y + offsetY,
            transform.position.z
        );
    }
}
