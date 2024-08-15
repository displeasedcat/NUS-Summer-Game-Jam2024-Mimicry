using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // References:
    public Rigidbody2D rb;
    public WeaponScript weapon;

    // Variables:
    public float moveSpeed = 5f;
    Vector2 moveDirection;
    Vector2 mousePosition;

    // Update is called once per frame

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if(Input.GetMouseButtonDown(0)) {
            weapon.Fire();
        }
        
        moveDirection = new Vector2(moveX, moveY).normalized; 
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
    // void Update()
    // {
    //     // Getting the vertical input for forward/backward movement
    //     float moveY = Input.GetAxisRaw("Vertical");

    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         weapon.Fire();
    //     }

    //     // Update the mouse position
    //     mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //     // Calculate the move direction
    //     Vector2 aimDirection = (mousePosition - (Vector2)transform.position).normalized;
    //     moveDirection = moveY * aimDirection;
    // }

    // void FixedUpdate()
    // {
    //     // Set the player's velocity to move forward/backward based on the mouse direction
    //     rb.velocity = moveDirection * moveSpeed;

    //     // Rotate the player to face the mouse position
    //     Vector2 aimDirection = mousePosition - rb.position;
    //     float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
    //     rb.rotation = aimAngle;
    // }
}
