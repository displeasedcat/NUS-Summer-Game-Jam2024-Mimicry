using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField]
    private float speed;
    private Vector2 playerDirection;

    private Rigidbody2D rb;
    private EnemyAwareness enemyAwareness;

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyAwareness = GetComponent<EnemyAwareness>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        UpdateDirection();
        UpdateVelocity();
    }

    private void UpdateDirection() {
        if(enemyAwareness.Aware) {
            playerDirection = enemyAwareness.DirectionPlayer;
        } else {
            playerDirection = Vector2.zero;
        }
    }

    private void UpdateVelocity() {
        if(playerDirection == Vector2.zero) {
            rb.velocity = Vector2.zero;
        } else {
            rb.velocity = playerDirection.normalized * speed;
        }
    }
}
