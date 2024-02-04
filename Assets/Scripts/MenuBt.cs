using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBt : MonoBehaviour
{
    [SerializeField] private Button playBt;
    //[SerializeField] private Button exitBt;
    [SerializeField] private Button creditsBt;

    [SerializeField] private Button backMenuBt;
    [SerializeField] private GameObject creditsPanel;

    void Start()
    {
        playBt.gameObject.SetActive(true);
        //exitBt.gameObject.SetActive(true);
        creditsBt.gameObject.SetActive(true);
        creditsPanel.SetActive(false);
    }

    public void Play(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    // public void Exit(){
    //     Debug.Log("Exit");
    //     Application.Quit();
    // }

    public void Credits(){
        Debug. Log(creditsPanel.activeSelf);
        if(creditsPanel.activeSelf){
            creditsPanel.SetActive(false);
            playBt.gameObject.SetActive(true);
            //exitBt.gameObject.SetActive(true);
            creditsBt.gameObject.SetActive(true);

        } else{
            creditsPanel.SetActive(true);
            playBt.gameObject.SetActive(false);
            //exitBt.gameObject.SetActive(false);
            creditsBt.gameObject.SetActive(false);
        }

    }

    public void BackMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
