using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score;
    private int hit, total;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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

    public int GetScore() { return score; }
    public int GetHits() { return hit; }
    public int getTotal() { return total; }
    public int GetMiss() { return total - hit; }

}
