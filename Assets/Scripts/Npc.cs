using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{

    Sprite[] charSprites = new Sprite[2];

    void Start()
    {

        charSprites =  this.gameObject.GetComponentInParent<CreateNpc>().getRandomSprite();
        this.GetComponent<SpriteRenderer>().sprite =  charSprites[0];
        if(this.gameObject.GetComponentInParent<CreateNpc>().GetBiggerNpc()){
            transform.localScale += new Vector3(0.8f, 0.8f, 0.8f);
        }
        if(!(this.gameObject.GetComponentInParent<CreateNpc>().GetIsLeft())){
             this.GetComponent<SpriteRenderer>().flipX = false;
        }

    }

    [SerializeField] private float speed;

    public void getAngry(){
        this.GetComponent<SpriteRenderer>().sprite =  charSprites[1];
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
