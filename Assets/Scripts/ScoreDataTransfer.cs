using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDataTransfer : MonoBehaviour
{
    ScoreManager scoreManager;
    ScoreManager scoreManagerInGame;

    public static ScoreDataTransfer playerInstance;
    float score;
    // Start is called before the first frame update
    void Start()
    {   
        scoreManager = this.GetComponent<ScoreManager>();
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (playerInstance == null) {
            playerInstance = this;
        } else {
            Destroy(this.gameObject);
        }
    }
    
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    } 

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Mode: " + mode);
        Debug.Log("Scene: " + scene.buildIndex);
        scoreManager = this.GetComponent<ScoreManager>();
        if(GameObject.FindWithTag("score") != null)
        {
            scoreManagerInGame = GameObject.FindWithTag("score").GetComponent<ScoreManager>();
            if(scene.buildIndex == 1)
            {
                Debug.Log("resetou data score manager");
                scoreManager.ResetScore();
            }
            if(scene.buildIndex == 2)
            {
                scoreManagerInGame.setScore((int)scoreManager.GetScore());
                scoreManagerInGame.SetScoreToAdd((int)scoreManager.GetScoreToAdd());

            }
        }
    }
    public void setData()
    {
        scoreManager.setScore((int)scoreManagerInGame.GetScore());
        scoreManager.SetScoreToAdd((int)scoreManagerInGame.GetScoreToAdd());
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1){
            setData();
        }
    }

}
