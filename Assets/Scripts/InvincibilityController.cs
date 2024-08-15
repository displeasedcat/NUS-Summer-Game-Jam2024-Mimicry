using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
    private HealthController hc;

    void Awake()
    {
        hc = GetComponent<HealthController>();
    }

    public void StartInvin(float duration)
    {
        StartCoroutine(InvinCoroutine(duration));
    }

    private IEnumerator InvinCoroutine(float duration) {
        hc.invincible = true;
        yield return new WaitForSeconds(duration);
        hc.invincible = false;
    }
}
