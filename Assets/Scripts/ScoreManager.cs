using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float score;	

    [SerializeField] private float scoreToAdd;
    [SerializeField] private float scorePerSecond;
    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    public void AddScore(float points){
        scoreToAdd += points;
        //scoreText.text = score.ToString();
    }

    public void SubtractScore(float points){
        score -= points;
        scoreText.text = score.ToString();
    }

    public void ResetScore(){
        scoreToAdd = 0;
        score = 0;
        scoreText.text = score.ToString();
    }

    public float GetScore(){
        return score;
    }

    void Update()
    {
        if (scoreToAdd > 0){
            scoreText.text = ((int)score + 1).ToString();
            scoreToAdd -= scorePerSecond * Time.deltaTime;
            score += scorePerSecond * Time.deltaTime;
        }
    }
}
