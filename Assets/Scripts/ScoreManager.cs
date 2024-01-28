using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;	
    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    public void AddScore(int points){
        score += points;
        scoreText.text = score.ToString();
    }

    public void SubtractScore(int points){
        score -= points;
        scoreText.text = score.ToString();
    }

    public void ResetScore(){
        score = 0;
        scoreText.text = score.ToString();
    }

    public int GetScore(){
        return score;
    }
}
