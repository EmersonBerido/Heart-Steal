using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
