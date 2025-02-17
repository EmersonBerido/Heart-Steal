using UnityEngine;
using UnityEngine.SceneManagement;
public class GameFinished : MonoBehaviour
{
    public void finishGame()
    {
        SceneManager.LoadScene(0);
    }
}
