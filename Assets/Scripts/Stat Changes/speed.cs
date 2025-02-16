using UnityEngine;

public class speed : MonoBehaviour
{
    public float speedMultiplier;
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
            Debug.Log("if reached");
            if (isBoost)
            {
                //increases speed of player
                player1.GetComponent<Player1Behavior>().setSpeedMultiplier(speedMultiplier);
            } 
            else
            {
                //decreases other player's speed
                player2.GetComponent<Player2Behavior>().setSpeedMultiplier(speedMultiplier);
                Debug.Log("decrease speed");
            }
            Destroy(gameObject);
        } 
        else
        {
            Debug.Log("else reached");

            if (isBoost)
            {
                //increases speed of player
                player2.GetComponent<Player2Behavior>().setSpeedMultiplier(speedMultiplier);
            } 
            else
            {
                Debug.Log("Crumnl cookie");
                //decreases other player's speed
                player1.GetComponent<Player1Behavior>().setSpeedMultiplier(speedMultiplier);
                Debug.Log("end crumnl");
            }
            Destroy(gameObject);
        }
    }
}
