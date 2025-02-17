using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //ngl idk what this does but its what the yt vid is doing :))
    [SerializeField] TextMeshProUGUI timerText;
    public float time;
    public bool iscCountdownDone = false;

    // Update is called once per frame
    void Update()
    {

        if (iscCountdownDone)
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
        }

    }

    public void startTimer()
        {
            iscCountdownDone = true;
        }
}
