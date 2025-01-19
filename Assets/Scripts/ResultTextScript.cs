using UnityEngine;
using UnityEngine.UI;

public class ResultTextScript : MonoBehaviour
{
    public Text resultText;

    void Update()
    {
        resultText.text = "Score: " + ScoreManager.Instance.GetScore() + "/100";
    }
}
