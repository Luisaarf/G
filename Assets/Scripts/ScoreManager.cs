using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreTextBackground;
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
        scoreTextBackground.text = score.ToString();
    }

    public void ResetScore(){
        scoreToAdd = 0;
        score = 0;
        scoreText.text = score.ToString();
        scoreTextBackground.text = score.ToString();
    }

    public float GetScore(){
        return score;
    }

    public float GetScoreToAdd(){
        return scoreToAdd;
    }

    public void setScore(float newScore){
        score = newScore;
        scoreText.text = score.ToString();
        scoreTextBackground.text = scoreText.text;
    }

    public void changeBackgroundScore(){
        scoreTextBackground.text = scoreText.text;
    }

    void Update()
    {
        if (scoreToAdd > 0){
            scoreText.text = ((int)score + 1).ToString();
            changeBackgroundScore();
            scoreToAdd -= scorePerSecond * Time.deltaTime;
            score += scorePerSecond * Time.deltaTime;
        }

    }
}
