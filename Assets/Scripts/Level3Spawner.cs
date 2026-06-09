using UnityEngine;

public class Level3Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public GameObject movingKeyPrefab;

    public GameObject doorPrefab;

    void Start()
    {
        SpawnEnemy(10f);

        SpawnEnemy(16f);

        SpawnEnemy(22f);

        SpawnEnemy(28f);

        SpawnEnemy(34f);

        SpawnEnemy(40f);

        SpawnMovingKey(34);

        SpawnEnemy(46f);

        SpawnEnemy(52f);

        SpawnEnemy(58f);

        SpawnEnemy(64f);

        SpawnEnemy(70f);

        SpawnDoor(76f);
    }

    void SpawnEnemy(float x)
    {
        Vector3 pos =
            new Vector3(x, -2f, 0);

        GameObject enemy =
            Instantiate(enemyPrefab, pos, Quaternion.identity);

        enemy.GetComponent<EnemyWalker>().speed = 5f;
    }

    void SpawnMovingKey(float x)
    {
        Vector3 pos =
            new Vector3(x, -1f, 0);

        GameObject movingKey =
            Instantiate(movingKeyPrefab, pos, Quaternion.identity);

        movingKey.GetComponent<MovingKey>().moveSpeed = 4f;
    }

    void SpawnDoor(float x)
    {
        Vector3 pos =
            new Vector3(x, -3f, 0);

        GameObject door =
            Instantiate(doorPrefab, pos, Quaternion.identity);
    }
}