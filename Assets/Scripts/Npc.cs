using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{

    Sprite[] charSprites = new Sprite[2];
    //this is going to be the sound that the npc makes when it is hit
    [SerializeField] private AudioSource hitBaloonSound;
    [SerializeField] private AudioSource hitNpcSound;
    [SerializeField] private AudioSource laughSound;

    [SerializeField] private float speed;
    [SerializeField] private MinigameManager minigameManager;
    void Start()
    {
        minigameManager = GameObject.Find("MinigameManager").GetComponent<MinigameManager>();
        speed = minigameManager.getDifficulty() * speed;
        hitBaloonSound = GameObject.Find("FirstMinigame").GetComponent<AudioSource>();
        hitNpcSound = GameObject.Find("Street1").GetComponent<AudioSource>();
        laughSound = GameObject.Find("player").GetComponent<AudioSource>();
        charSprites =  this.gameObject.GetComponentInParent<CreateNpc>().getRandomSprite();
        this.GetComponent<SpriteRenderer>().sprite =  charSprites[0];
        if(this.gameObject.GetComponentInParent<CreateNpc>().GetBiggerNpc()){
            transform.localScale += new Vector3(0.8f, 0.8f, 0.8f);
        }
        if(!(this.gameObject.GetComponentInParent<CreateNpc>().GetIsLeft())){
             this.GetComponent<SpriteRenderer>().flipX = false;
        }

    }


    public void getAngry(){
        this.GetComponent<SpriteRenderer>().sprite =  charSprites[1];
        hitNpcSound.Play();
        hitBaloonSound.Play();
        laughSound.Play();

    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = speed * Time.deltaTime;
        if(this.gameObject.GetComponentInParent<CreateNpc>().GetIsLeft()){
            transform.Translate(movementSpeed, 0 , 0);
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        if(!(this.gameObject.GetComponentInParent<CreateNpc>().GetIsLeft())){
            transform.Translate(-(movementSpeed), 0 , 0);
            transform.position += new Vector3(-(movementSpeed), 0, 0);
        }
    }
}
