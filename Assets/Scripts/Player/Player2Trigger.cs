using UnityEngine;

public class Player2Trigger : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !player2.GetComponent<Player2Behavior>().isHoldingHeart && player2.GetComponent<Player2Behavior>().internalTimer > 3 && player1.GetComponent<Player1Behavior>().isHoldingHeart)
        {
            player1.GetComponent<Player1Behavior>().setHeart(false);
            player1.GetComponent<Player1Behavior>().resetTimer();
            player2.GetComponent<Player2Behavior>().setHeart(true);
            player2.GetComponent<Player2Behavior>().resetTimer();
        }
    }
}
