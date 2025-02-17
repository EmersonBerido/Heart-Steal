using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public GameObject timerTextRef;
    public float time;
    public GameObject player1;
    public GameObject player2;
    public GameObject GameTimer;

    void Start()
    {
        //players cant move till countdown is 0
        player1.GetComponent<Player1Behavior>().enabled = false;
        player2.GetComponent<Player2Behavior>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {

        
        time -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(time % 60);



        timerText.text = string.Format("{0:0}", seconds, time);
        if (seconds < 0)
        {
            player1.GetComponent<Player1Behavior>().enabled = true;
            player2.GetComponent<Player2Behavior>().enabled = true;

            GameTimer.GetComponent<Timer>().startTimer();
            timerTextRef.SetActive(false);
        }
    }
}
