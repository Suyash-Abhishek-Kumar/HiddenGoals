using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene("HomeScreen");
        ScoreManager.Instance.resetScore();
        ScoreManager.Instance.resetGoal();
    }

    public void play()
    {
        SceneManager.LoadScene("GamePlay");
        if (ScoreManager.Instance.GetScore() == 100) { ScoreManager.Instance.resetGoal(); Debug.Log("new goal set"); }
        ScoreManager.Instance.resetScore();
    }

    public void quitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void story()
    {
        SceneManager.LoadScene("Story");
    }
}
