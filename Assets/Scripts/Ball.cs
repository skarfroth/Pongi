using UnityEngine;

public class Ball : MonoBehaviour
{
    public float movementSpeed = 6f;

    private Rigidbody2D rb2d;
    private Vector3 movementVector;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        movementVector.x = Random.Range(0,2) == 1 ? -1 : 1;
        movementVector.y = Random.Range(-0.8f, 0.8f);
    }

    private void FixedUpdate()
    {
        rb2d.velocity = movementVector.normalized * movementSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Paddle"))
        {
            movementSpeed++;
            movementVector.x = -movementVector.x;
            movementVector.y = -transform.InverseTransformPoint(collision.transform.position).y;
        }

        else if (collision.CompareTag("Wall"))
        {
            movementVector.y = -movementVector.y;
        }
    }
}
