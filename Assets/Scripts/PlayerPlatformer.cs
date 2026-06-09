using UnityEngine;

public class PlayerPlatformer : MonoBehaviour
{
    public float speed = 6f;

    public float jumpForce = 12f;

    public float minX = -8.5f;

    public float maxX = 8.5f;

    public Transform groundCheck;

    public float groundCheckRadius = 0.2f;

    public LayerMask groundLayer;

    private Rigidbody2D rb;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckGround();

        Move();

        Jump();

        LimitPosition();
    }

    void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            groundLayer
        );
    }

    void Move()
{
    float move = 0f;

    bool walking = false;

    if(Input.GetKey(KeyCode.A))
    {
        move = -1f;

        walking = true;
    }

    if(Input.GetKey(KeyCode.D))
    {
        move = 1f;

        walking = true;
    }

    rb.linearVelocity =
        new Vector2(move * speed, rb.linearVelocity.y);

    if(walking && isGrounded)
    {
        AudioManager.instance.StartWalkSound();
    }
    else
    {
        AudioManager.instance.StopWalkSound();
    }
}

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            AudioManager.instance.PlaySFX(
        AudioManager.instance.jumpSFX
    );
            rb.linearVelocity =
                new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    void LimitPosition()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }
}