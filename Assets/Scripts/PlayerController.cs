using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool shouldUse2PControls;

    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float playerClampOffsetTop = 5f;
    [SerializeField] private float playerClampOffsetBottom = 5f;

    private Rigidbody2D rb2d;
    private Vector3 movementVector;
    private Vector3 minScreenBounds;
    private Vector3 maxScreenBounds;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    private void Update()
    {
        // Prevents player from going off screen
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minScreenBounds.y + playerClampOffsetBottom, maxScreenBounds.y - playerClampOffsetTop), transform.position.z);
        if (!shouldUse2PControls)
        {
            movementVector.y = Input.GetAxis("Vertical");
        }
        if (shouldUse2PControls)
        {
            movementVector.y = Input.GetAxis("Vertical2");
        }
    }
    private void FixedUpdate()
    {
        rb2d.velocity = movementVector * movementSpeed;
    }
}
