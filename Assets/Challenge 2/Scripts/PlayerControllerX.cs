using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool canSpawnDog = true;

    void Start()
    {
        StartCoroutine("ResetSpawnability");
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawnDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawnDog = false;
        }
    }

    private IEnumerator ResetSpawnability()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            canSpawnDog = true;
        }
    }
}
