using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PistoleBonusProjectile : MonoBehaviour
{
    public static event Action OnPistoleBonusProjectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            Destroy(gameObject);
            OnPistoleBonusProjectile?.Invoke();
        }
    }
}
