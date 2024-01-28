using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool hit;
    [SerializeField] private bool itMoves;
    [SerializeField] ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("Likes").GetComponent<ScoreManager>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (hit) return; 
        if (itMoves){ 
            float movementSpeed = speed * Time.deltaTime;
            transform.Translate(0, movementSpeed, 0);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        GameObject.Find("player").GetComponent<PlayerMovement>().backToNormal();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("npc"))
        {
            hit = true;
            Destroy(gameObject);
            GameObject.Find("player").GetComponent<PlayerMovement>().backToNormal();
            collision.gameObject.GetComponent<Npc>().getAngry();
            scoreManager.AddScore(100);
        }
    }
}

