using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundDone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void nextRound()
    {
        SceneManager.LoadScene(1);
    }
}
