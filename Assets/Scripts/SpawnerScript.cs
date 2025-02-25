using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject targetPrefab;
    private float spawnInterval = 1.4f;
    public Transform spawnArea;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnTarget), 0, spawnInterval);
    }

    void SpawnTarget()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-8, 8),
            Random.Range(-4, 3),
            0);

        Instantiate(targetPrefab, randomPosition, Quaternion.identity);
    }
}
