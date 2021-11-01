using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f;

    private Vector3 movementVector;
    private Vector3 minScreenBounds;
    private Vector3 maxScreenBounds;

    private void Start()
    {
        minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    private void Update()
    {
        // Prevents player from going off screen
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, (minScreenBounds.y + 1.5f), (maxScreenBounds.y - 1.5f)), transform.position.z);

        // Move player
        movementVector.y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(movementVector);
    }
}
