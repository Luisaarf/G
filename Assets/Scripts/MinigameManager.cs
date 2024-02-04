using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    [SerializeField] private GameObject thegame;

    [SerializeField] private Timer timer;

    [SerializeField] private float firstMinigameTimer;

    int currentMinigame = 0;

    //variable to set the difficulty
    private float difficulty;
    // Start is called before the first frame update
    void Start()
    {
      thegame.SetActive(true);
      SetTimerMinigame();
      difficulty = 1;
    }

    public float getDifficulty(){
      return difficulty;
    }

    public void ChangeMinigame(){
        thegame.SetActive(false);
        difficulty++;
        if (difficulty > 3)
        {
          //condição de vitória
          UnityEngine.SceneManagement.SceneManager.LoadScene("End");
        }
        thegame.SetActive(true);
        SetTimerMinigame();
        Debug.Log("Difficulty: " + difficulty);
    }


    // public void ChangeMinigame(){
    //     minigames[currentMinigame].SetActive(false);
    //     currentMinigame++;
    //     difficulty++;
    //     if (currentMinigame >= minigames.Length)
    //     {
    //         currentMinigame = 0;
    //     }
    //     minigames[currentMinigame].SetActive(true);
    //     SetTimerMinigame();
    //     Debug.Log("Difficulty: " + difficulty);
    // }

    public void SetTimerMinigame(){
        if (currentMinigame == 0)
        {
          timer.setTimer(firstMinigameTimer);
        }
    }

}
