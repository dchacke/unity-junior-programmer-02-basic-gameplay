using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float minWait = 3;
    private float maxWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnRandomBall");
    }

    // Spawn random ball at random x position at top of play area
    private IEnumerator SpawnRandomBall()
    {
        while (true)
        {
            UnityEngine.WaitForSeconds wait = new WaitForSeconds(Random.Range(minWait, maxWait + 1));

            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            // instantiate ball at random spawn location
            GameObject ballPrefab = ballPrefabs[Random.Range(0, 3)];
            Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);

            yield return wait;
        }
    }

}
