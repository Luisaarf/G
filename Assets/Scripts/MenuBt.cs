using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBt : MonoBehaviour
{
    [SerializeField] private Button playBt;
    [SerializeField] private Button exitBt;
    [SerializeField] private Button creditsBt;

    [SerializeField] private Button backMenuBt;
    [SerializeField] private GameObject creditsPanel;
    private AudioSource buttonAudio;

    void Start()
    {
        buttonAudio = GetComponent<AudioSource>();
        playBt.gameObject.SetActive(true);
        exitBt.gameObject.SetActive(true);
        creditsBt.gameObject.SetActive(true);
        creditsPanel.SetActive(false);
    }

    public void Play(){
        buttonAudio.Play();
        StartCoroutine(WaitForSound(buttonAudio.clip));
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public IEnumerator WaitForSound(AudioClip Sound){
        yield return new WaitUntil(() => buttonAudio.isPlaying == false);
    }

    public void Exit(){
        buttonAudio.Play();
        StartCoroutine(WaitForSound(buttonAudio.clip));
        Application.Quit();
    }

    public void Credits(){
        buttonAudio.Play();
        if(creditsPanel.activeSelf){
            creditsPanel.SetActive(false);
            playBt.gameObject.SetActive(true);
            exitBt.gameObject.SetActive(true);
            creditsBt.gameObject.SetActive(true);

        } else{
            creditsPanel.SetActive(true);
            playBt.gameObject.SetActive(false);
            exitBt.gameObject.SetActive(false);
            creditsBt.gameObject.SetActive(false);
        }

    }

    public void BackMenu(){
        buttonAudio.Play();
        StartCoroutine(WaitForSound(buttonAudio.clip));
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
