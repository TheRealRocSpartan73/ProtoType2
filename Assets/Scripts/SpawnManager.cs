using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;  //Collection of animals to spawn
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = 0;  //Index into animalPrefabs array
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnRangeZ); //Create a new random spawn vector
            
            animalIndex = Random.Range(0, animalPrefabs.Length); //Randomly select our animal object

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
