using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    [SerializeField]
    private float duration;

    private InvincibilityController ic;

    public void Awake()
    {
        ic = GetComponent<InvincibilityController>();
    }

    public void StartInviFrame()
    {
        ic.StartInvin(duration);
    }
}
