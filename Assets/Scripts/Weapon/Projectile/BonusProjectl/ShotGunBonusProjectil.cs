using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShotGunBonusProjectil : MonoBehaviour
{
    public static event Action OnShotGunProjectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            Destroy(gameObject);
            OnShotGunProjectile?.Invoke();
        }
    }
}
