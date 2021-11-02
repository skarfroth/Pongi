using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float movementSpeed = 6f;
    private Vector3 movementVector;
    private Rigidbody2D rb2d;

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

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Paddle"))
        {
            movementSpeed++;
            movementVector.x = -movementVector.x;
            movementVector.y = -transform.InverseTransformPoint(other.transform.position).y;
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            movementVector.y = -movementVector.y;
        }
    }
}
