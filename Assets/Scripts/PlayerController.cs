using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float timeDiff = 0f;
    public float speed = 10.0f;
    public float leftBoundary = -10f;
    public float rightBoundary = 10f;
    public GameObject projecttilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeDiff = Time.deltaTime;//Capture number of frames since Update was called
        //Boundary for moving player left
        if(transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }
        //Boundary for moving player left
        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        //Move Left or right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * timeDiff * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //LauchProjectile
            Instantiate(projecttilePrefab, transform.position, projecttilePrefab.transform.rotation);
        }
        
    }
}
