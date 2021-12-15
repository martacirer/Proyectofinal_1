using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBonds : MonoBehaviour
{
    private float xmax = 300f;
    private float ymax = 300f;
    private float zmax = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xmax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > ymax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zmax)
        {
            Destroy(gameObject);
        }

        
    }
}
