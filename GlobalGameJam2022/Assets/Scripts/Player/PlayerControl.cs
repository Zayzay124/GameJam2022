using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    //private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;

    private int extraJumps;
    public int extraJumpsValue;

    Vector2 origPos;

    void Start()
    {
        origPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        extraJumps = extraJumpsValue;
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update()
    {
       if(isGrounded == true) {
            extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0) {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true) {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

}
