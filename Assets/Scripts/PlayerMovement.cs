using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Vector3 moveAmount;

    private InputManager inputManager;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputManager = GetComponent<InputManager>();
        inputManager.OnMove += Move;
    }

    private void Move(object sender, Vector2 e)
    {
        moveAmount = e * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveAmount; 
    }

}
