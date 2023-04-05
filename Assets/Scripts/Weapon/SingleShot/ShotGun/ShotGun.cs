using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    private void OnEnable()
    {
        ProjctlShotGun.RealSoundSingleShotWeapon += StartDamage; 
    }
    private void OnDisable()
    {
        ProjctlShotGun.RealSoundSingleShotWeapon -= StartDamage; 
    }
    private void ScaneHit(RaycastHit _hit)
    {
        var colliderGameObj = _hit.collider.gameObject;
        if (!colliderGameObj.TryGetComponent(out IWeaponVisitor weaponVisitor)) return;
        Accept(weaponVisitor, _damageWeapon, _hit);
    }
    protected override void Accept(IWeaponVisitor weaponVisitor, float damageWeapon, RaycastHit hit)
    {
        weaponVisitor.Visit(this, _damageWeapon, base.hit);

    }
    private void StartDamage()
    {
        ScaneHit(hit);
    }
}
