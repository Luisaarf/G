using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            ResetScore();
        }
    }

    private void UpdateText(){
        if(scoreTextBackground != null){
            scoreText.text = score.ToString();
            scoreTextBackground.text = score.ToString();
        }
    }

    public void AddScore(float points){
        scoreToAdd += points;
    }

    public void SubtractScore(float points){
        score -= points;
        scoreText.text = score.ToString();
        scoreTextBackground.text = score.ToString();
    }

    public void ResetScore(){
        scoreToAdd = 0;
        score = 0;
        UpdateText();
    }

    public float GetScore(){
        return score;
    }

    public float GetScoreToAdd(){
        return scoreToAdd;
    }

    public void SetScoreToAdd(float newScoreToAdd){
        scoreToAdd = newScoreToAdd;
        UpdateText();
    }

    public void setScore(float newScore){
        score = newScore ;
        UpdateText();
    }

    public void changeBackgroundScore(){
        scoreTextBackground.text = scoreText.text;
    }

    void Update()
    {
        if (scoreToAdd > 0){
            if(scoreTextBackground != null){
                scoreText.text = ((int)score + 1).ToString();
                changeBackgroundScore();
            }
            scoreToAdd -= scorePerSecond * Time.deltaTime;
            score += scorePerSecond * Time.deltaTime;
        }

    }
}
