using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    // This is an array with all the minigames in the game.
    [SerializeField] private GameObject[] minigames;

    [SerializeField] private Timer timer;

    [SerializeField] private float firstMinigameTimer;
    [SerializeField] private float secondMinigameTimer;
    [SerializeField] private float thirdMinigameTimer;

    int currentMinigame = 0;

    //variable to set the difficulty
    int difficulty;
    // Start is called before the first frame update
    void Start()
    {
      minigames[0].SetActive(true);
      for (int i = 1; i < minigames.Length; i++)
      {
          minigames[i].SetActive(false);
      }

      difficulty = 0;
    }

    public void ChangeMinigame(){
        minigames[currentMinigame].SetActive(false);
        currentMinigame++;
        difficulty++;
        if (currentMinigame >= minigames.Length)
        {
            currentMinigame = 0;
        }
        minigames[currentMinigame].SetActive(true);
        SetTimerMinigame();
        Debug.Log("Difficulty: " + difficulty);
    }

    public void SetTimerMinigame(){
        if (currentMinigame == 0)
        {
          timer.setTimer(firstMinigameTimer);
        }
        else if (currentMinigame == 1)
        {
          timer.setTimer(secondMinigameTimer);
        }
        else if (currentMinigame == 2)
        {
          timer.setTimer(thirdMinigameTimer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
