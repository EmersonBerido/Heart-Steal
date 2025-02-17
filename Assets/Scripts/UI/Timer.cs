using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //ngl idk what this does but its what the yt vid is doing :))
    [SerializeField] TextMeshProUGUI timerText;
    public float time;
    public bool isCountdownDone = false;
    bool isTimerDone = false;
    public GameObject player1;
    public GameObject player2;
    public GameObject GameManager;

    // Update is called once per frame
    void Update()
    {
        if (isTimerDone)
        {
            player1.GetComponent<Player1Behavior>().player1RoundDone();
            player2.GetComponent<Player2Behavior>().player2RoundDone();
            GameManager.GetComponent<RoundTracker>().TimerDone();
            gameObject.SetActive(false);
        }


        if (isCountdownDone)
        {
            //Debug.Log("reached");
            time -= Time.deltaTime;
            int seconds = Mathf.FloorToInt(time % 60);
            if (seconds < 10)
            {
                timerText.text = string.Format("{0:0}", seconds, time);
            }
            else
            {
                timerText.text = string.Format("{0:00}", seconds, time);
            }
            if (seconds <= 0)
            {
                isTimerDone = true;
            }
        }
        

    }

    public void startTimer()
        {
            isCountdownDone = true;
        }
}
