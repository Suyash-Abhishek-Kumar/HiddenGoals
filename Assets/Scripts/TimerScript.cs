using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    private float roundDuration = 10f;
    private float timeRemaining;

    private void Start()
    {
        timeRemaining = roundDuration;
        StartCoroutine(TimerCountdown());
    }

    private IEnumerator TimerCountdown()
    {
        while (timeRemaining > 0)
        {
            timerText.text = "Time: " + Mathf.Ceil(timeRemaining).ToString();
            timeRemaining -= Time.deltaTime;
            yield return null;
        }
        EndRound();
    }

    private void EndRound()
    {
        Debug.Log("Round Over!");
        SceneManager.LoadScene("Result");
    }
}

