using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //When collison between objects occurs, delete both objects.
    private void OnTriggerEnter(Collider other)
    {

        //If player is hit by an animal -- game over man
        if (other.CompareTag("myFarmer"))
        {
            Debug.Log("Game Over Farmer Killed");
            Destroy(gameObject);
        }
        else   //Destroy anything else when collision detected
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
