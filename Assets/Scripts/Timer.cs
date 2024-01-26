using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeRemaining;
    [SerializeField] private Slider timerSlider;

    [SerializeField] private MinigameManager minigameManager;
    public bool timerIsRunning = false;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    public float getTimer()
    {
        return timeRemaining;
    }

    public void setTimer(float time)
    {
        timeRemaining = time;
        timerSlider.value = timeRemaining;
        timerSlider.maxValue = timeRemaining;
        timerIsRunning = true;
    }

    void Update()
    {
       if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }


            timerSlider.value = timeRemaining;
        }
        else {
            minigameManager.ChangeMinigame();
        }
    }
}
