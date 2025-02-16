using UnityEngine;

public class Heart : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameObject.Find("Player 1"))
        {
            other.GetComponent<Player1Behavior>().setHeart(true);
            gameObject.SetActive(false);
        } else 
        {
            other.GetComponent<Player2Behavior>().setHeart(true);
            gameObject.SetActive(false);
        }
    }
}
