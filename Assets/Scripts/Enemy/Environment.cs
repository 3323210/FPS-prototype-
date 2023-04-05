using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Environment : MonoBehaviour, IWeaponVisitor
{
    [SerializeField] protected GameObject _hitDent;

    public void Visit(Knife weapon, float damage)
    {

    }

    public void Visit(Pistole weapon, float damage, RaycastHit hit)
    {
        Quaternion _rotationBlodPrefab = Quaternion.LookRotation(hit.normal);
        Instantiate(_hitDent, hit.point, _rotationBlodPrefab);
    }

    public void Visit(ShotGun weapon, float damage, RaycastHit hit)
    {
        Quaternion _rotationBlodPrefab = Quaternion.LookRotation(hit.normal);
        Instantiate(_hitDent, hit.point, _rotationBlodPrefab);
    }
    public void Visit(MachineGun weapon, float damage, RaycastHit hit)
    {
        if (damage > 0)
        {
            Quaternion _rotationBlodPrefab = Quaternion.LookRotation(hit.normal);
            Instantiate(_hitDent, hit.point, _rotationBlodPrefab);
        }
    }

}