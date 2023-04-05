using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MachineGunBonusProjectil : MonoBehaviour
{
    public static event Action OnMachineGunProjectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            Destroy(gameObject);
            OnMachineGunProjectile?.Invoke();
        }
    }
}
