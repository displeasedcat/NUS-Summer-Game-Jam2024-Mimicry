using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAwareness : MonoBehaviour
{

    public bool Aware {get; private set;}

    public Vector2 DirectionPlayer{get; private set;}

    [SerializeField]
    private float awarenessRange;

    [SerializeField]
    private float deagroRange;

    private Transform player;

    public UnityEvent Activated;
    public UnityEvent Deactivated;

    
    private void Awake()
    {
        player = FindObjectOfType<NewBehaviourScript>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayer = player.position - transform.position;
        DirectionPlayer = enemyToPlayer.normalized;

        bool wasAware = Aware;

        if (enemyToPlayer.magnitude <= awarenessRange)
        {
            Aware = true;
            //Activated.Invoke();
        } 
        else if (enemyToPlayer.magnitude >= deagroRange)
        {
            Aware = false;
            //Deactivated.Invoke();
        }

        if (Aware && !wasAware)
        {
            Activated.Invoke();
        }
        else if (!Aware && wasAware)
        {
            Deactivated.Invoke();
        }
    }
}
