using UnityEngine;

public class PlataformCollider : MonoBehaviour
{
    private Collider platformCollider;
    private Collider playerCollider;
    private Rigidbody playerRb;

    void Start()
    {
        platformCollider = GetComponent<Collider>();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerCollider = player.GetComponent<Collider>();
        playerRb = player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (playerRb.linearVelocity.y > 0)
        {
            Physics.IgnoreCollision(playerCollider, platformCollider, true);
        }
        else
        {
            Physics.IgnoreCollision(playerCollider, platformCollider, false);
        }
    }
}
