using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPistolActivate : State
{
    private Pistole _weaponPistol;

    public WeaponPistolActivate(Pistole pistol)
    {
        _weaponPistol = pistol;
    }
   
    public override void Enter()
    {
        base.Enter();
        _weaponPistol.gameObject.SetActive(true);
    }
    public override void Exit()
    {
        base.Exit();
        _weaponPistol.gameObject.SetActive(false);
    }
}
