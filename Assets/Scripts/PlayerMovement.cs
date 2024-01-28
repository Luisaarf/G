using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject balloon;
    [SerializeField] private float cooldownTimer = Mathf.Infinity;
    [SerializeField] private Sprite hienaWaiting;
    [SerializeField] private Sprite hiena;

    Vector3 touchPosition;
    [SerializeField] float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Attack()
    {
        Instantiate(balloon, firePoint.position, firePoint.rotation);
        cooldownTimer = 0;
    }

    public void backToNormal()
    {
        this.GetComponent<SpriteRenderer>().sprite = hiena;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.tapCount == 1)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                position = Vector2.Lerp(transform.position, touchPosition, moveSpeed);
                position.y = 1.91f;
                rb.MovePosition(position);
            }
            if(touch.tapCount == 2 && cooldownTimer > attackCooldown)
            {
                this.GetComponent<SpriteRenderer>().sprite = hienaWaiting;
                Attack();
            }

        }
        
        cooldownTimer += Time.deltaTime;

    }
}
