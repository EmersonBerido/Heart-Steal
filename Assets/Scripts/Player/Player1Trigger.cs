using UnityEngine;

public class Player1Trigger : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !player1.GetComponent<Player1Behavior>().isHoldingHeart && player1.GetComponent<Player1Behavior>().internalTimer > 3 && player2.GetComponent<Player2Behavior>().isHoldingHeart)
        {
            player2.GetComponent<Player2Behavior>().setHeart(false);
            player2.GetComponent<Player2Behavior>().resetTimer();
            player1.GetComponent<Player1Behavior>().setHeart(true);
            player1.GetComponent<Player1Behavior>().resetTimer();
        }
    }
}
