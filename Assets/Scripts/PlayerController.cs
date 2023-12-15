using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float[] xRange = {-10.0f, 10.0f};
    public float[] zRange = {0.0f, 10.0f};

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float z = transform.position.z;

        if (transform.position.x < xRange[0])
        {
            x = xRange[0];
        }
        else if (transform.position.x > xRange[1])
        {
            x = xRange[1];
        }

        if (transform.position.z < zRange[0])
        {
            z = zRange[0];
        }
        else if (transform.position.z > zRange[1])
        {
            z = zRange[1];
        }

        transform.position = new Vector3(x, transform.position.y, z);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
