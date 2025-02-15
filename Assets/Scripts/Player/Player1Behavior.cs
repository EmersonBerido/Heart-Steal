using UnityEngine;

public class Player1Behavior : MonoBehaviour
{
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    private Rigidbody2D rb;
    public float speed = 2.0f;
    public float jump = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            //moves player left
            rb.linearVelocityX = -speed;
        } else if (Input.GetKey(right))
        {
            //moves player right
            rb.linearVelocityX = speed;
        } else
        {
            //stops player if nothing is pressed
            rb.linearVelocityX = 0;
        }

        if (Input.GetKeyDown(up))
        {
            rb.linearVelocityY = jump;
        }
    }
}
