using UnityEngine;

public class Player2Behavior : MonoBehaviour
{   
    //Control Variables
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode up = KeyCode.UpArrow;
    public KeyCode down = KeyCode.DownArrow;
    //Physics Variables
    private Rigidbody2D rb;
    public float speed;
    public float currSpeed;
    public float jump;
    private float currJump;
    public Transform groundCheck;
    public bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    //Heart variables
    public bool isHoldingHeart = false;
    public GameObject heartIndicator;
    public float internalTimer = 0.0f;
    public float statsTimer = 0.0f;
    //Player Reference
    public GameObject otherPlayer;
    //Out of Bounds Variables
    public float outOfBoundsY = -6.0f;
    private float respawnTimer = 0.0f;
    public float respawnInterval = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currSpeed = speed;
        currJump = jump;
        otherPlayer = GameObject.Find("Player 1");
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
                Debug.Log("stats resetted");
            }
        }

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

        //Player Movement
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

        transform.rotation = Quaternion.Euler(0,transform.rotation.eulerAngles.y,0);

        //Checks if out of bounds
        if (transform.position.y < outOfBoundsY)
        {
            if (isHoldingHeart)
            {
                isHoldingHeart = false;
                otherPlayer.GetComponent<Player1Behavior>().setHeart(true);
            }
            respawnTimer += Time.deltaTime;
            if (respawnTimer > respawnInterval)
            {
                transform.position = new Vector3(0,1.5f,0);
                respawnTimer = 0;
            }
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

    public void player2RoundDone()
    {
        if (isHoldingHeart)
        {
            PlayerPrefs.SetInt("Player2Win", PlayerPrefs.GetInt("Player2Win") + 1);
        }
    }
}
