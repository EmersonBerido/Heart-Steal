using UnityEngine;

public class Player1Behavior : MonoBehaviour
{
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    private Rigidbody2D rb;
    public float speed;
    public float currSpeed;
    public float jump;
    public float currJump;
    public Transform groundCheck;
    public bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    //Heart variables
    public bool isHoldingHeart = false;
    public GameObject heartIndicator;
    public float internalTimer = 0.0f;
    public float statsTimer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currSpeed = speed;
        currJump = jump;

    }

    // Update is called once per frame
    void Update()
    {
        internalTimer += Time.deltaTime;

        if (currSpeed != speed || currJump != jump)
        {
            statsTimer += Time.deltaTime;
            if (statsTimer > 3)
            {
                currSpeed = speed;
                currJump = jump;
                statsTimer = 0;
            }
        }

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
            rb.linearVelocityX = -currSpeed;
            //faces ghost left
            transform.rotation = Quaternion.Euler(0,180,0);
        } else if (Input.GetKey(right))
        {
            //moves player right
            rb.linearVelocityX = currSpeed;
            //faces ghost right
            transform.rotation = Quaternion.Euler(0,0,0);
        } else
        {
            //stops player if nothing is pressed
            rb.linearVelocityX = 0;
        }

        if (Input.GetKeyDown(up) && isGrounded)
        {
            rb.linearVelocityY = currJump;
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

    public void setSpeedMultiplier(float multiplier)
    {
        currSpeed = speed * multiplier;
    }

    public void setJumpMultiplier(float multiplier)
    {
        currJump = jump * multiplier;
    }
}
