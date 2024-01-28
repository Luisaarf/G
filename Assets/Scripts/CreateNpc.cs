using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNpc : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private Transform firePoint;
    [SerializeField] private float npcCreationCooldown;
    [SerializeField] private GameObject adultNpc;
    [SerializeField] private float cooldownTimer = Mathf.Infinity;
    [SerializeField] private bool isLeft;
    [SerializeField] private bool biggerNpc;
    [SerializeField] private Sprite[] characterSprites;
    [SerializeField] private Sprite[] oppositeCharacterSprites;

    void InstantiateNpc()
    {

        Instantiate(adultNpc, transform.position, transform.rotation, this.transform);
        cooldownTimer = 0;
    }

    public Sprite[] getRandomSprite(){
        int random = Random.Range(0, characterSprites.Length);
        Sprite[] charArray = new Sprite[2];
        charArray[0] = characterSprites[random];
        charArray[1] = oppositeCharacterSprites[random];
        return charArray ;
    }

    public bool GetIsLeft(){
       return isLeft;
    }

    public bool GetBiggerNpc(){
       return biggerNpc;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer > npcCreationCooldown)
        {
            InstantiateNpc();
        }
        cooldownTimer += Time.deltaTime;
    }
}
