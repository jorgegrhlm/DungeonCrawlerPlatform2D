using UnityEngine;

public class Level1Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public GameObject keyPrefab;

    public GameObject doorPrefab;

    void Start()
    {
        SpawnEnemy(10f);

        SpawnEnemy(16f);

        SpawnKey(19f);

        SpawnEnemy(22f);

        SpawnEnemy(28f);

        SpawnDoor(36f);
    }

    void SpawnEnemy(float x)
    {
        Vector3 pos =
            new Vector3(x, -2f, 0);

        GameObject enemy =
            Instantiate(enemyPrefab, pos, Quaternion.identity);

        enemy.GetComponent<EnemyWalker>().speed = 3f;
    }

    void SpawnKey(float x)
    {
        Vector3 pos =
            new Vector3(x, -2f, 0);

        Instantiate(keyPrefab, pos, Quaternion.identity);
    }

    void SpawnDoor(float x)
    {
        Vector3 pos =
            new Vector3(x, -3f, 0);

        Instantiate(doorPrefab, pos, Quaternion.identity);
    }
}