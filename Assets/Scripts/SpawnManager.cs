using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int index = Random.Range(0, prefabs.Length);
            GameObject prefab = prefabs[index];
            Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 0, 12);

            Instantiate(prefab, spawnPosition, prefab.transform.rotation);
        }
    }
}
