using UnityEngine;

public class Level2Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public GameObject keyPrefab;

    public GameObject doorPrefab;

    void Start()
    {
        SpawnEnemy(10f);

        SpawnEnemy(16f);

        SpawnEnemy(22f);

        SpawnEnemy(28f);

        SpawnKey(24f);

        SpawnEnemy(34f);

        SpawnEnemy(40f);

        SpawnEnemy(46f);

        SpawnEnemy(52f);

        SpawnDoor(58f);
    }

    void SpawnEnemy(float x)
    {
        Vector3 pos =
            new Vector3(x, -2f, 0);

        GameObject enemy =
            Instantiate(enemyPrefab, pos, Quaternion.identity);

        enemy.GetComponent<EnemyWalker>().speed = 4f;
    }

    void SpawnKey(float x)
    {
        Vector3 pos =
            new Vector3(x, -1f, 0);

        Instantiate(keyPrefab, pos, Quaternion.identity);
    }

    void SpawnDoor(float x)
    {
        Vector3 pos =
            new Vector3(x, -3f, 0);

        Instantiate(doorPrefab, pos, Quaternion.identity);
    }
}