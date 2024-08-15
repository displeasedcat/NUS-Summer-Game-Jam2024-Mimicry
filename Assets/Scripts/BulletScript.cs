using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{


    [SerializeField]
    private float damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var hc = collision.gameObject.GetComponent<HealthController>();
        if (hc != null)
        {
            //Debug.Log("Player Hit");
            hc.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
