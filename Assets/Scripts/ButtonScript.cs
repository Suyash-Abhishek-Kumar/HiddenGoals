using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public AudioSource button;
    public void home() { StartCoroutine(home_c()); }

    public void play() { StartCoroutine(play_c()); }

    public void quitGame() { StartCoroutine(quit_c()); }

    public void story() { StartCoroutine(story_c()); }

    private IEnumerator play_c()
    {
        button.Play();
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene("GamePlay");
        if (ScoreManager.Instance.GetScore() == 100) ScoreManager.Instance.resetGoal();
        ScoreManager.Instance.resetScore();
    }

    private IEnumerator quit_c()
    {
        button.Play();
        yield return new WaitForSeconds(0.15f);
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    private IEnumerator story_c()
    {
        button.Play();
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene("Story");
    }

    private IEnumerator home_c()
    {
        button.Play();
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene("HomeScreen");
        ScoreManager.Instance.resetScore();
        ScoreManager.Instance.resetGoal();
    }
}
