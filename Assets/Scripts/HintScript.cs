using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour
{
    public Text hintBox;
    public Text goalBox;
    private string[][] hints = new string[][]
    {
        new string[] { "Watch your targets carefully before clicking.", "Fewer mistakes lead to a perfect score." },
        new string[] { "Some targets are better left untouched.", "Some temptations are best ignored."},
        new string[] { "Not all targets are created equal — prioritize!", "Some targets are worth more. Choose wisely." },
        new string[] { "Ignore distractions; stay true to one color path", "There's a pattern you're meant to follow."},
        new string[] { "Be ready for the next target—every second counts!", "Keep your focus sharp and strike fast." },
        new string[] { "Every misstep casts a long shadow.", "Patience is key; don't rush into clicks." }
    };
    void Start()
    {
        if (ScoreManager.Instance.GetScore() != 100)
        {
            hintBox.text = hints[ScoreManager.Instance.GetGoal()][Random.Range(0, 2)];
            goalBox.text = "Goal: ???";
        }
        else
        {
            hintBox.text = "Congratulations of finishing your training";
            goalBox.text = "Goal: " + ScoreManager.Instance.GetGoalName();
        }
    }
}
