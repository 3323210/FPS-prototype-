using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MachineGun : Weapon
{
    [SerializeField] private ProjctlMachineGun projctlMachineGun;
    private float _damageMachineGun;

    private void OnEnable()
    {
        ProjctlMachineGun.OnShotBoletTrue += FullDamage;
        ProjctlMachineGun.OnShotBoletFalse += ZeroDamage;
    }
    private void OnDisable()
    {
        ProjctlMachineGun.OnShotBoletTrue -= FullDamage;
        ProjctlMachineGun.OnShotBoletFalse -= ZeroDamage;
    }
    
    private void ScaneHit(RaycastHit _hit)
    {
        var colliderGameObj = _hit.collider.gameObject;
        if (!colliderGameObj.TryGetComponent(out IWeaponVisitor weaponVisitor)) return;
        Accept(weaponVisitor, _damageWeapon, _hit);
    }
    private void FullDamage()
    {
        _damageMachineGun = _damageWeapon;
        ScaneHit(hit);
    }
    private void ZeroDamage()
    {
        _damageMachineGun = 0;
    }
    
    protected override void Accept(IWeaponVisitor weaponVisitor, float damage,RaycastHit hit)
    {
        weaponVisitor.Visit(this, _damageMachineGun, hit);
        
    }

}
