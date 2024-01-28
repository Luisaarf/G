using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool hit;
    [SerializeField] private bool itMoves;
    
    // Update is called once per frame
    void Update()
    {
        if (hit) return; 
        if (itMoves){ 
            float movementSpeed = speed * Time.deltaTime;
            transform.Translate(0, movementSpeed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Projectile hit something");
        if (collision.gameObject.CompareTag("npc"))
        {
            hit = true;
            Destroy(gameObject);
            collision.gameObject.GetComponent<Npc>().getAngry();
        }
    }
}

