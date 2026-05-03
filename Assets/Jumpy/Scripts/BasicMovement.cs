using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckMovement();
    }

    public void CheckMovement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
}