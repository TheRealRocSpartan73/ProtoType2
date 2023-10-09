using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 34;
    private float bottomBoundary = -11.5f;
    private float sideBoundary = 30f; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If a pizza or animal object goes past game screen boundaries, remove it.
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < bottomBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if ((transform.position.x > sideBoundary) || (transform.position.x < -sideBoundary)) //If object moves past left OR Right boundary, delete
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
            

    }
}
