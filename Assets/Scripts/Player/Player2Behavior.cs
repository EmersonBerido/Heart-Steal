using UnityEngine;

public class Player2Behavior : MonoBehaviour
{    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode up = KeyCode.UpArrow;
    public KeyCode down = KeyCode.DownArrow;
    private Rigidbody2D rb;
    public float speed = 5.0f;
    public float jump = 5.0f;
    public Transform groundCheck;
    public bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    //Heart variables
    public bool isHoldingHeart = false;
    public GameObject heartIndicator;
    public float internalTimer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        internalTimer += Time.deltaTime;
        //activates indicator if hearth is held
        if (isHoldingHeart)
        {
            heartIndicator.SetActive(true);
        }
        else 
        {
            heartIndicator.SetActive(false);
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


        if (Input.GetKey(left))
        {
            //moves player left
            rb.linearVelocityX = -speed;
            //faces ghost left
            transform.rotation = Quaternion.Euler(0,180,0);
        } else if (Input.GetKey(right))
        {
            //moves player right
            rb.linearVelocityX = speed;
            //faces ghost right
            transform.rotation = Quaternion.Euler(0,0,0);
        } else
        {
            //stops player if nothing is pressed
            rb.linearVelocityX = 0;
        }

        if (Input.GetKeyDown(up) && isGrounded)
        {
            rb.linearVelocityY = jump;
        }
    }

    public void setHeart(bool isHoldingHeart)
    {
        this.isHoldingHeart = isHoldingHeart;
    }

    public void resetTimer()
    {
        internalTimer = 0.0f;
    }
}
