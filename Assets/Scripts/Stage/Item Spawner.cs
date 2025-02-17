using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] powerUps;
    public float startTime;
    public float spawnRate;
    public float spawnLimitPosY = 1;
    public float spawnLimitNegY = -2;
    public float spawnLimitX = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", startTime, spawnRate);
    }

    void SpawnPowerUp()
    {
        int randomPowerUpIndex = Random.Range(0, powerUps.Length);
        int spawnPositionY = Random.Range(0,2);
        Vector2 spawnPosition;
        if (spawnPositionY == 1)
        {
            spawnPosition = new Vector2(Random.Range(-spawnLimitX, spawnLimitX), spawnLimitPosY);
        }
        else{
            spawnPosition = new Vector2(Random.Range(-spawnLimitX, spawnLimitX), spawnLimitNegY);
        }

        Instantiate(powerUps[randomPowerUpIndex], spawnPosition, powerUps[randomPowerUpIndex].transform.rotation);

    }

}
