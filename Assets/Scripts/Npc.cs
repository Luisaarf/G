using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{

    void Start()
    {
        if(this.gameObject.GetComponentInParent<CreateNpc>().GetBiggerNpc()){
            transform.localScale += new Vector3(0.8f, 0.8f, 0.8f);
        }
    }

    [SerializeField] private float speed;

    public void Die(){
        Destroy(gameObject);
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
