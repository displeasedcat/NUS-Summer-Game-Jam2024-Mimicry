using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackScript : MonoBehaviour
{

    [SerializeField]
    private float health;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<NewBehaviourScript>())
        {
            var hc = collision.gameObject.GetComponent<HealthController>();
            hc.AddHealth(health);
            Destroy(gameObject);
        }
    }
}
