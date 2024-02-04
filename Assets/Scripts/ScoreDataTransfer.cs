using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDataTransfer : MonoBehaviour
{
    ScoreManager scoreManager;
    float score;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = this.GetComponent<ScoreManager>();
    }

    void Update()
    {
        if(GameObject.Find("Likes").GetComponent<ScoreManager>().GetScoreToAdd() > 0 )
        {
            scoreManager.setScore( (int)(GameObject.Find("Likes").GetComponent<ScoreManager>().GetScore() + 1));
            return;
        }
    }

}
