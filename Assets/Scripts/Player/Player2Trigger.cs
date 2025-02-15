using UnityEngine;

public class Player2Trigger : MonoBehaviour
{
    public GameObject player2;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Player" && !player2.GetComponent<Player1Behavior>().isHoldingHeart && player2.GetComponent<Player2Behavior>().internalTimer > 3)
        {
            Debug.Log("If Triggered");
            other.GetComponent<Player1Behavior>().setHeart(false);
            player2.GetComponent<Player2Behavior>().setHeart(true);
            player2.GetComponent<Player2Behavior>().resetTimer();
        }
    }
}
