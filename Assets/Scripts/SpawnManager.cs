using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;  //Collection of animals to spawn
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sidespawnX;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Spawn random animal that will move "down" the screen
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);  ////Randomly select our animal object index
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ); //Create a new random spawn vector
        

        //Create and spawn the animal object into the game scene
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    //Spawn Random animal that will move left to right
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);  ////Randomly select our animal object index
        Vector3 spawnPos = new Vector3(-sidespawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); //Create a random animal on leftside
        //Rotate our model before spawning
        Vector3 leftRotation = new Vector3(0, -90, 0);

        //Create and spawn the animal object into the game scene
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(leftRotation));
    }

    //Spawn Random animal that will move right to left
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);  ////Randomly select our animal object index
        Vector3 spawnPos = new Vector3(sidespawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); //Create a random animal on leftside

        //Rotate our model before spawning
        Vector3 leftRotation = new Vector3(0, 90, 0);

        //Create and spawn the animal object into the game scene
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(leftRotation));
    }

}
