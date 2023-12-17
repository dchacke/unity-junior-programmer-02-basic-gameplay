using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float leftBound = -20;
    private float rightBound = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x > rightBound || transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerBound) {
            PointsManager.decLives();
        }
    }
}
