using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject fastEnemy;
    public GameObject heavyEnemy;
    public GameObject progressiveEnemy;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, 2f);
    }

    void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, 3);

        Vector3 spawnPos = new Vector3(8, 0, 0);

        if (randomEnemy == 0)
        {
            Instantiate(fastEnemy, spawnPos, Quaternion.identity);
        }
        else if (randomEnemy == 1)
        {
            Instantiate(heavyEnemy, spawnPos, Quaternion.identity);
        }
        else
        {
            Instantiate(progressiveEnemy, spawnPos, Quaternion.identity);
        }
    }
}
