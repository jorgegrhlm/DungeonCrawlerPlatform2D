using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public GameObject keyPrefab;

    public GameObject doorPrefab;

    private int currentStep = 0;

    void Start()
    {
        InvokeRepeating("SpawnSequence", 1f, 2f);
    }

    void SpawnSequence()
    {
        Vector3 spawnPos =
            new Vector3(transform.position.x, -2f, 0);

        // Enemy 1
        if(currentStep == 0)
        {
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }

        // Enemy 2
        else if(currentStep == 1)
        {
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }

        // KEY
        else if(currentStep == 2)
        {
            Instantiate(keyPrefab, spawnPos, Quaternion.identity);
        }

        // Enemy 3
        else if(currentStep == 3)
        {
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }

        // Enemy 4
        else if(currentStep == 4)
        {
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }

        // DOOR
        else if(currentStep == 5)
        {
            Instantiate(doorPrefab, spawnPos, Quaternion.identity);

            CancelInvoke();
        }

        currentStep++;
    }
}