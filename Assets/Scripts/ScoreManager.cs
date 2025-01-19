using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score, hit, total;
    private int[] colors = { 0, 0, 0, 0, 0, 0 };
    private string[] goals = { "Accuracy", "Target Avoidance", "Target Prioritization", "Monotone Selection", "Reaction Time", "Mistake Reduction" };
    private int current_goal;
    private int special_color;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            current_goal = Random.Range(0, 4);
            print(goals[current_goal]);
            if (current_goal != 0)
            {
                special_color = Random.Range(0, 2);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points;
        hit += 1;
        total += 1;
        Debug.Log($"Score: {score}");
    }

    public void MissPenalty(int points)
    {
        score -= points;
        total += 1;
        if (score < 0) score = 0;
        Debug.Log($"Score: {score}");
    }

    public void color(int color, bool hit) {
        if (hit) colors[color]++;
        colors[color + 3]++;
    }
    public void resetScore() {
        score = 0;
        hit = 0;
        total = 0;
        colors = new int[]{0, 0, 0, 0, 0, 0};
    }
    public void SetScore(int new_score) { score = new_score; }
    public void resetGoal() {
        current_goal = Random.Range(0, 4);
        if (current_goal != 0)
        {
            special_color = Random.Range(0, 2);
        }
    }
    public int GetGoal() { return current_goal; }
    public string GetGoalName() { return goals[current_goal]; }
    public int GetScore() { return score; }
    public int GetHits() { return hit; }
    public int getTotal() { return total; }
    public int GetMiss() { return total - hit; }
    public int[] GetColors() { return colors; }
    public int GetSpecialColor() { return special_color; }
}
