using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private float currHealth;

    [SerializeField]
    private float maxHealth;

    public float healthPercent
    {
        get
        {
            return currHealth / maxHealth;
        }
    }

    public bool invincible {get;set;}

    public UnityEvent onDie;

    public UnityEvent onDamage;

    public UnityEvent onHealthChanged;

    public void TakeDamage(float damage)
    {
        if (currHealth == 0 || invincible)
        {
            return;
        }
        currHealth -= damage;
        if (currHealth <= 0)
        {
            currHealth = 0;
            onDie.Invoke();
        } else if (!invincible) {
            onDamage.Invoke();
        }
        onHealthChanged.Invoke();
    }

    public void AddHealth(float health)
    {
        currHealth += health;
        if (currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }
        onHealthChanged.Invoke();
    }



}
