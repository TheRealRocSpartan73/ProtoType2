using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; //Capture horizontal movement
    public float verticalInput;  //Capture vertical movement
    public float timeDiff = 0f; //Capture time between frames
    public float speed = 10.0f; //Player movement speed
    public float leftBoundary = -23.4f;  //Left boundary for player movement
    public float rightBoundary = -23.3f;  //Right boundary for player movement
    public float topBoundary = 20.0f; //Top boundary for player movement
    public float bottomBoundary = 0f; //Bottom boundary for player movement
    public Transform projectileSpawnPoint;

    public GameObject projecttilePrefab; //Placeholder for the attached pizza object


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
        //Set boundaries for player moving up or down
        if (transform.position.z < bottomBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomBoundary);
        }
        if (transform.position.z > topBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topBoundary);
        }


        //Move Left or right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * timeDiff * speed);

        //Move Up or Down
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * timeDiff * speed);

        //If player hits space then create a new pizza object
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //LauchProjectile, but instantiate it in a bit in front of player to avoid collision
            Instantiate(projecttilePrefab, projectileSpawnPoint.position, projecttilePrefab.transform.rotation);
        }
        
    }
}
