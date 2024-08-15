using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private float damage;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<NewBehaviourScript>())
        {
            //Debug.Log("Player Hit");
            var hc = collision.gameObject.GetComponent<HealthController>();
            hc.TakeDamage(damage);
        }
        // else 
        // {
        //     print("Enemy Hit");
        //     Debug.Log("Enemy Hit");
        //     var hc = collision.gameObject.GetComponent<HealthController>();
        //     hc.TakeDamage(damage);
        // }
    }
}
