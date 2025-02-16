using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpMultiplier;
    public bool isBoost;
    public GameObject player1;
    public GameObject player2;

    void Start()
    {
        player1 = GameObject.Find("Player 1");
        player2 = GameObject.Find("Player 2");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameObject.Find("Player 1"))
        {
            if (isBoost)
            {
                //increases jump of player
                player1.GetComponent<Player1Behavior>().setJumpMultiplier(jumpMultiplier);
            } 
            else
            {
                //decreases other player's jump
                player2.GetComponent<Player2Behavior>().setJumpMultiplier(jumpMultiplier);
            }
            Destroy(gameObject);
        } 
        else
        {
            Debug.Log("else reac");
            if (isBoost)
            {
                //increases jump of player
                player2.GetComponent<Player2Behavior>().setJumpMultiplier(jumpMultiplier);
            } 
            else
            {
                //decreases other player's jump
                player1.GetComponent<Player1Behavior>().setJumpMultiplier(jumpMultiplier);
    
            }
            Destroy(gameObject);
        }
    }
}
