using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] starPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
        InvokeRepeating("SpawnStars", 1, 0.02f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        int spawnPos = Random.Range(-38, 39);
        Instantiate(enemyPrefabs[0], new Vector3(33, 50, spawnPos), enemyPrefabs[0].transform.rotation);
    }

    void SpawnStars()
    {
        int spawnPosY = Random.Range(5, 11);
        int spawnPosZ = Random.Range(-130, 131);
        int starIndex = Random.Range(0, starPrefabs.Length);

        Instantiate(starPrefabs[starIndex], new Vector3(65, spawnPosY, spawnPosZ), starPrefabs[starIndex].transform.rotation);
    }
}
