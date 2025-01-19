using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene("HomeScreen");
        ScoreManager.Instance.resetScore();
    }

    public void play()
    {
        SceneManager.LoadScene("GamePlay");
        ScoreManager.Instance.resetScore();
    }

    public void quitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
