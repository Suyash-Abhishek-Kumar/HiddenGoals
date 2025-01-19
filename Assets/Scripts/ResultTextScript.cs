using UnityEngine;
using UnityEngine.UI;

public class ResultTextScript : MonoBehaviour
{
    public Text resultText;
    private int score;

    void Awake()
    {
        int goal = ScoreManager.Instance.GetGoal();
        switch (goal)
        {
            case 0:
                score = ScoreManager.Instance.GetHits() * 100 / ScoreManager.Instance.getTotal();
                break;

            case 1:
                int avoid = ScoreManager.Instance.GetSpecialColor();
                int[] colors = ScoreManager.Instance.GetColors();
                if (colors[avoid + 3] > 0) score = (1 - colors[avoid] / colors[avoid + 3]) * 100;
                else score = 100;
                break;

            case 2:
                int priority = ScoreManager.Instance.GetSpecialColor();
                int[] color = ScoreManager.Instance.GetColors();
                score = color[priority] * 100 / color[priority + 3];
                break;

            case 3:
                int mono = ScoreManager.Instance.GetSpecialColor();
                int[] colour = ScoreManager.Instance.GetColors();
                score = (1 - (ScoreManager.Instance.GetHits() - colour[mono]) / (ScoreManager.Instance.getTotal() - colour[mono + 3])) * 100;
                break;

            case 4:
                break;
        }
        ScoreManager.Instance.SetScore(score);
        resultText.text = "Score: " + score;
    }


}
