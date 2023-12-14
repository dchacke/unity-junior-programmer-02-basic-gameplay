using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, prefabs.Length);
        GameObject prefab = prefabs[index];
        Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 0, 20);

        Instantiate(prefab, spawnPosition, prefab.transform.rotation);
    }
}
