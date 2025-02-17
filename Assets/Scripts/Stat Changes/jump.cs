using Unity.VisualScripting;
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
        if (other.gameObject == GameObject.Find("trigger1") || other.gameObject == player1)
        {
            Debug.Log(other.name);
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
