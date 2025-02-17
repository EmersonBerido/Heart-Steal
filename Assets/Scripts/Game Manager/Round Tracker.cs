using UnityEngine;

public class RoundTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Player1Score") >= 2)
        {
            //resets scores
            PlayerPrefs.SetInt("Player1Score", 0);
            //TODO Player 1 wins
        }
        else if (PlayerPrefs.GetInt("Player2Score") >= 2)
        {
            //resets scores
            PlayerPrefs.SetInt("Player2Score", 0);
            //TODO Player 2 wins
        }
    }
}
