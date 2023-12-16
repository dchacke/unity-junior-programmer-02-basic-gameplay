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

        Vector3 spawnPosition;
        Quaternion rotation;

        bool aggressive = isAggressive();

        if (aggressive)
        {
            if (spawnLeft())
            {
                spawnPosition = new Vector3(-20, 0, Random.Range(0, 20));

                // As per https://forum.unity.com/threads/how-to-adjust-my-prefab-to-face-the-correct-direction-when-instantiated.780023/#post-5192006
                rotation = Quaternion.LookRotation(Vector3.right);
            }
            else
            {
                spawnPosition = new Vector3(20, 0, Random.Range(0, 20));
                rotation = Quaternion.LookRotation(Vector3.left);
            }
        }
        else
        {
            spawnPosition = new Vector3(Random.Range(-7, 7), 0, 20);
            rotation = prefab.transform.rotation;
        }

        GameObject animal = Instantiate(prefab, spawnPosition, rotation);

        if (aggressive)
        {
            animal.gameObject.tag = "AggressiveAnimal";
        }
    }

    // Make a spawned animal aggressive with 50% chance
    private bool isAggressive()
    {
        return Random.Range(0, 2) == 0 ? true : false;
    }

    // Make aggressive animal spawn on the left with 50% chance
    private bool spawnLeft()
    {
        return Random.Range(0, 2) == 0 ? true : false;
    }
}
