using UnityEngine;

public class Player1Trigger : MonoBehaviour
{
    public GameObject player1;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Player" && !player1.GetComponent<Player1Behavior>().isHoldingHeart && player1.GetComponent<Player1Behavior>().internalTimer > 3)
        {
            Debug.Log("If Triggered");
            other.GetComponent<Player2Behavior>().setHeart(false);
            player1.GetComponent<Player1Behavior>().setHeart(true);
            player1.GetComponent<Player1Behavior>().resetTimer();
        }
    }
}
