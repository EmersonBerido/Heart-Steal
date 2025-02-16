using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //ngl idk what this does but its what the yt vid is doing :))
    [SerializeField] TextMeshProUGUI timerText;
    public float time;
    public float startTime;

    void Start()
    {
        time += startTime;
        //sets timer to be not visible at start
        timerText.color =  new Color(timerText.color.r, timerText.color.g, timerText.color.b, 0);
    }
    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;

        //sets timer to be visinle after countdown
        if (startTime <= 0)
        {
            timerText.color =  new Color(timerText.color.r, timerText.color.g, timerText.color.b, 255);
        }
        
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
    }
}
