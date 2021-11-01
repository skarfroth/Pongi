using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float movementSpeed = 6f;

    private Vector3 movementVector;

    private void Start()
    {
        movementVector.x = Random.Range(-0.8f, 0.8f);
        movementVector.y = Random.Range(-0.8f, 0.8f);
    }

    private void Update()
    {
        transform.Translate(movementVector.normalized * movementSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {

    }
}
