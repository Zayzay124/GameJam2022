using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    //private bool facingRight = true; ignore for now

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;

    private int extraJumps;
    public int extraJumpsValue;


    Vector2 origPos;

    public bool isDay;

    void Start()
    {
        origPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        extraJumps = extraJumpsValue;

        /*
         * origPos is the location of where the player spawns
         * rb allows us to add a rigidbody to the player meaning it can be affected by gravity
         * extraJumps is the number of times the player can jump in the air after their initial jump
         */
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        /*
         * isGrounded is a boolean that is true when the player is on the ground and fals otherwise
         * moveInput takes the values of "GetAxis(Horizontal)". this is a built in Unity function
         * when the left key is pressed moveInput will equal -1 and when the right key is pressed it will equal 1
         */
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            isDay = !isDay;
        }

        if (isGrounded == true) {
            extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0) { //if the up key is pushed and 
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true) {
            rb.velocity = Vector2.up * jumpForce;
        }

        /*
         * 
         */
    }

}
