using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShotGunlActivate : State
{
    private ShotGun _weaponShotGun;

    public WeaponShotGunlActivate(ShotGun shotGun)
    {
        _weaponShotGun = shotGun;
    }
   
    public override void Enter()
    {
        base.Enter();
        _weaponShotGun.gameObject.SetActive(true);
    }
    public override void Exit()
    {
        base.Exit();
        _weaponShotGun.gameObject.SetActive(false);
    }
}
