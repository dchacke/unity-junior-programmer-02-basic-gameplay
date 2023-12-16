using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Pizza") && (other.CompareTag("Animal") || other.CompareTag("AggressiveAnimal")))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (gameObject.CompareTag("Player") && other.CompareTag("AggressiveAnimal"))
        {
            Debug.Log("Game Over from aggressive!");
        }
    }
}
