using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private SpriteRenderer sr;
    Color[] predefinedColors = { Color.red, Color.green, Color.yellow };
    private float shrinkSpeed = 0.05f;
    private float minScale = 0.1f;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ChangeColor();
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x <= minScale)
        {
            Despawn();
        }
    }

    void ChangeColor()
    {
        Color selectedColor = predefinedColors[Random.Range(0, predefinedColors.Length)];
        sr.color = selectedColor;
    }

    void OnMouseDown()
    {
        HitTarget();
    }

    void HitTarget()
    {
        Debug.Log("Hit!");
        ScoreManager.Instance.AddScore(10);
        Destroy(gameObject);
    }

    void Despawn()
    {
        Debug.Log("Miss!");
        ScoreManager.Instance.MissPenalty(5);
        Destroy(gameObject);
    }
}
