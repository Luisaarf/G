using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    // This is an array with all the minigames in the game.
    [SerializeField] private GameObject[] minigames;

    //variable to set the difficulty
    //int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < minigames.Length; i++)
        {
            minigames[i].SetActive(false);
        }

        //difficulty = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
