using UnityEngine;

public class RoundTracker : MonoBehaviour
{
    public GameObject roundDoneScreen;
    public GameObject gameDoneScreen;
    public GameObject player1OneWin;
    public GameObject player2OneWin;

    void Start()
    {
        if (PlayerPrefs.GetInt("Player1Win") == 1)
        {
            player1OneWin.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Player2Win") == 1)
        {
            player2OneWin.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("player 1 score" + PlayerPrefs.GetInt("Player1Win"));
            Debug.Log("player 2 score" + PlayerPrefs.GetInt("Player2Win"));
        }
        if (PlayerPrefs.GetInt("Player1Win") >= 2)
        {
            //resets scores
            PlayerPrefs.SetInt("Player1Win", 0);
            PlayerPrefs.SetInt("Player2Win", 0);
        }
        else if (PlayerPrefs.GetInt("Player2Win") >= 2)
        {
            //resets scores
            PlayerPrefs.SetInt("Player1Win", 0);
            PlayerPrefs.SetInt("Player2Win", 0);
        } 
    }
    
    public void TimerDone()
    {
        if (PlayerPrefs.GetInt("Player1Win") >= 2 || PlayerPrefs.GetInt("Player2Win") >= 2)
        {
            gameDoneScreen.SetActive(true);
            //gameDoneScreen.SetActive(true); create another game done screen for each player
        } else
        {
            roundDoneScreen.SetActive(true);
        }
    }
}
