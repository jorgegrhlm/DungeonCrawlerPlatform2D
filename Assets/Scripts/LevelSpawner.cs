using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public GameObject keyPrefab;

    public GameObject movingKeyPrefab;

    public GameObject doorPrefab;

    void Start()
    {
        string sceneName =
            SceneManager.GetActiveScene().name;

        if(sceneName == "Level1")
        {
            SpawnLevel1();
        }

        if(sceneName == "Level2")
        {
            SpawnLevel2();
        }

        if(sceneName == "Level3")
        {
            SpawnLevel3();
        }
    }

    // LEVEL 1

    void SpawnLevel1()
    {
        SpawnEnemy(10f, 3f);

        SpawnEnemy(16f, 3f);

        SpawnKey(22f, -2f);

        SpawnEnemy(28f, 3f);

        SpawnEnemy(34f, 3f);

        SpawnDoor(40f);
    }

    // LEVEL 2

    void SpawnLevel2()
{
    SpawnEnemy(10f, 4f);

    SpawnEnemy(16f, 4f);

    SpawnEnemy(22f, 4f);

    SpawnEnemy(28f, 4f);

    SpawnKey(34f, -1f);

    SpawnEnemy(40f, 4f);

    SpawnEnemy(46f, 4f);

    SpawnEnemy(52f, 4f);

    SpawnEnemy(58f, 4f);

    SpawnDoor(64f);
}

    // LEVEL 3

    void SpawnLevel3()
    {
        SpawnEnemy(10f, 5f);

        SpawnEnemy(16f, 5f);

        SpawnEnemy(22f, 5f);

        SpawnEnemy(28f, 5f);

        SpawnEnemy(34f, 5f);

        SpawnEnemy(40f, 5f);

        SpawnMovingKey(46f, -2f);

        SpawnEnemy(52f, 5f);

        SpawnEnemy(58f, 5f);

        SpawnEnemy(64f, 5f);

        SpawnEnemy(70f, 5f);

        SpawnEnemy(76f, 5f);

        SpawnDoor(82f);
    }

    // ENEMY

    void SpawnEnemy(float x, float speed)
    {
        Vector3 pos =
            new Vector3(x, -2f, 0);

        GameObject enemy =
            Instantiate(enemyPrefab, pos, Quaternion.identity);

        enemy.GetComponent<EnemyWalker>().speed = speed;
    }

    // KEY

    void SpawnKey(float x, float y)
    {
        Vector3 pos =
            new Vector3(x, y, 0);

        Instantiate(keyPrefab, pos, Quaternion.identity);
    }

    // MOVING KEY

    void SpawnMovingKey(float x, float y)
    {
        Vector3 pos =
            new Vector3(x, y, 0);

        Instantiate(movingKeyPrefab, pos, Quaternion.identity);
    }

    // DOOR

    void SpawnDoor(float x)
    {
        Vector3 pos =
            new Vector3(x, -3f, 0);

        Instantiate(doorPrefab, pos, Quaternion.identity);
    }
}