using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollison : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //Get a reference to the GameManager object
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //When collison between objects occurs, delete both objects.
    private void OnTriggerEnter(Collider other)
    {

        //If player is hit by an animal reduce lives
        if (other.CompareTag("myFarmer"))
        {
            gameManager.AddLives(-1);
            Debug.Log("Farmer Hit");
            Destroy(gameObject);
        }
        else if(other.CompareTag("Animal"))   //Animal has been hit by pizza
        {
            gameManager.AddScore(5); //Increase score
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
