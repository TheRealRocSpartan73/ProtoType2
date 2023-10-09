using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider hungerSlider;    //Handle for slider based health bar
    public int requiredFeed;       //Number of pizzas each animal requires

    private int currentFedAmount = 0; //How much animal has been feed at start
    private GameManager gameManager;
    void Start()
    {
        //Setup slider max/min for each animal
        hungerSlider.maxValue = requiredFeed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false); //Turn this off as no feed received at start
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amount)
    {
        //Feed the animal and increase healthbar
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= requiredFeed) //If Animal is fully fed, remove
        {
            gameManager.AddScore(requiredFeed);
            Destroy(gameObject, 0.1f);
        }
    }
}
