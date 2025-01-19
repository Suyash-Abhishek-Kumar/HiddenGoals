using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private SpriteRenderer sr;
    private AudioSource aus;
    Color[] predefinedColors = { Color.cyan, Color.red, Color.yellow };
    private int color_index;
    private float shrinkSpeed = 0.1f;
    private float minScale = 0.1f;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        aus = GetComponent<AudioSource>();
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
        color_index = Random.Range(0, predefinedColors.Length);
        Color selectedColor = predefinedColors[color_index];
        sr.color = selectedColor;
    }

    void OnMouseDown()
    {
        aus.Play();
        Invoke("HitTarget", 0.2f);
    }

    void HitTarget()
    {
        Debug.Log("Hit!");
        ScoreManager.Instance.color(color_index, true);
        ScoreManager.Instance.AddScore(10);
        Destroy(gameObject);
    }

    void Despawn()
    {
        Debug.Log("Miss!");
        ScoreManager.Instance.color(color_index, false);
        ScoreManager.Instance.MissPenalty(5);
        Destroy(gameObject);
    }
}
