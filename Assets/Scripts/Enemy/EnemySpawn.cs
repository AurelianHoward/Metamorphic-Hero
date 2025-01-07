using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] Vector3 spawnPoint;

    int spawnRate = 1;

    void Start()
    {
        spawnPoint = transform.position;
        spawnPoint.y = 1;
    }
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        if (spawnRate > 60)
        {
            spawnRate = 1;
            Instantiate(EnemyPrefab, spawnPoint, Quaternion.identity);

        }
        else
        {
            spawnRate += 1;
        }
    }
}
