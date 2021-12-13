using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 10.0f;
    public float horizontalInput;
    public float verticalInput;

    private float xmax = 200f;
    private float ymax = 200f;
    private float zmax = 200f;

    public GameObject proyectil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Rotate(Vector3.left * speed * Time.deltaTime * verticalInput);

        

        //Rotación
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        if(transform.position.x > xmax)
        {
            transform.position = new Vector3(xmax, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xmax)
        {
            transform.position = new Vector3(-xmax, transform.position.y, transform.position.z);
        }
        if (transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax, transform.position.z);
        }
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (transform.position.z > zmax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zmax);
        }

        if (transform.position.z < -zmax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zmax);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(proyectil, transform.position, gameObject.transform.rotation);
        }

                
    }
}
